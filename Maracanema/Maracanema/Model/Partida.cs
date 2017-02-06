using Maracanema.Base;
using System;

namespace Maracanema.Model
{
    public class Partida : EntidadeBase
    {
        private int      _id;
        private DateTime _dtPartida;
        private int      _nuPlacarTimeA;
        private int      _nuPlacarTimeB;
        private bool     _bolFinalizado;


        public int Id { get; set; }
        public DateTime DtPartida { get; set; }
        public int NuPlacarTimeA { get; set; }
        public int NuPlacarTimeB { get; set; }
        public bool BolFinalizado { get; set; }

    }


}
