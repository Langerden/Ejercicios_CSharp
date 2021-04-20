using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public sealed class Cuadrado : Rectangulo
    {
        private double lado;

        public Cuadrado(double lado) : base(lado,lado)
        {
            this.lado = lado;
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }

        public override double CalcularSuperficie()
        {
            return this.lado * 2;
        }

        public override double CalcularPerimetro()
        {
            return this.lado * 4;
        }


    }
}
