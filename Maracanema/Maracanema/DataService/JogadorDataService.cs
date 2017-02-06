using Maracanema.Base;
using Maracanema.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Maracanema.DataService
{
    public class JogadorDataService : IRepositorio<Jogador>
    {

        private SQLiteConnection conexao;
        private static object colissionLock = new object();


        public JogadorDataService()
        {
            conexao = DependencyService.Get<IDatabaseConnection>().DBConnection();
            conexao.CreateTable<Jogador>();
        }

        public Jogador porId(int id)
        {
          lock(colissionLock)
            {
                if(id > 0)
                {
                    return conexao.Table<Jogador>().FirstOrDefault(m => m.Id == id);
                }
                return null;
            }

        }

        public int Salvar(Jogador jogador)
        {
          lock(colissionLock)
            {
                if(jogador.Id > 0)
                {
                    try
                    {
                        conexao.Update(jogador);
                        return jogador.Id;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }else
                {
                    try
                    {
                      conexao.Insert(jogador);
                      return 1;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
            }
        }

        public int Excluir(Jogador jogador)
        {
            lock (colissionLock)
            {
               if(jogador.Id > 0)
                {
                    try
                    {
                        var id = jogador.Id;
                        conexao.Delete<Jogador>(id);
                        return id;

                    }
                    catch (Exception)
                    {
                        return 0;
                    };
                }
                return 0;
            }
        }

        public IEnumerable<Jogador> listar()
        {
            lock (colissionLock)
            {
                return conexao.Table<Jogador>().ToList();
            }
        }
    }


}
