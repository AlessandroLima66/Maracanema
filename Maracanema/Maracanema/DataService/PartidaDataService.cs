using Maracanema.Base;
using Maracanema.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Maracanema.DataService
{
    public class PartidaDataService : IRepositorio<Partida>
    {

        private SQLiteConnection conexao;
        private static object colissionLock = new object();


        public PartidaDataService()
        {
            conexao = DependencyService.Get<IDatabaseConnection>().DBConnection();
            conexao.CreateTable<Partida>();
        }


        public Partida porId(int id)
        {
          lock(colissionLock)
            {
               if(id > 0)
                {
                    return conexao.Table<Partida>().FirstOrDefault(m => m.Id == id);
                }
                return null;
            }
        }

        public int Salvar(Partida partida)
        {
           lock(colissionLock)
            {
                if(partida.Id > 0)
                {
                    try
                    {
                        conexao.Update(partida);
                        return partida.Id;
                    }
                    catch(Exception)
                    {
                        return 0;
                    }
                }else
                {
                    try
                    {
                        conexao.Insert(partida);
                        return 1;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
            }
        }

        public int Excluir(Partida partida)
        {
            lock(colissionLock)
            {
                if (partida.Id > 0)
                {
                    try
                    {
                        var id = partida.Id;
                        conexao.Delete<Partida>(id);
                        return 1;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
                return 0;
            }
        }

        public IEnumerable<Partida> listar()
        {
          lock(colissionLock)
            {
                return conexao.Table<Partida>().ToList();
            }
        }



    }


}
