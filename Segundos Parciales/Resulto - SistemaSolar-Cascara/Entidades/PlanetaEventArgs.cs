using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanetaEventArgs
    {
        private short avance;
        private short radioRespectoSol;

        public PlanetaEventArgs(short avance, short radioRespectoSol)
        {
            this.avance = avance;
            this.radioRespectoSol = radioRespectoSol;
        }

        public short Avance { get => this.avance; }
        public short RadioRespectoSol { get => this.radioRespectoSol; }
    }
}
