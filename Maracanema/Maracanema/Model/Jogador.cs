using Maracanema.Base;
using System;

namespace Maracanema.Model
{
    public class Jogador : EntidadeBase
    {

        private int _id;
        private string _nmjogador;
        private string _nmapelido;
        private DateTime _dtnascimento;
        private string _nmposicao;


        public int Id
        {
            get { return _id; }
            set { _id = value; Notificacao();}
        }

        public string NmJogador
        {
            get { return _nmjogador; }
            set { _nmjogador = value; Notificacao(); }
        }

        public string NmApelido
        {
            get { return _nmapelido; }
            set { _nmapelido = value; Notificacao(); }
        }
        

        public DateTime DtNascimento
        {
            get { return _dtnascimento; }
            set { _dtnascimento = value; Notificacao(); }
        }

        public string NmPosicao
        {
            get { return _nmposicao; }
            set { _nmposicao = value; Notificacao(); }
        }


    }


}
