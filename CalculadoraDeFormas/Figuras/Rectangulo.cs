using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura
    {
        private double baseRect;
        private double altura;

        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return this.baseRect * this.altura;
        }

        public override double CalcularPerimetro()
        {
            return (this.baseRect * 2) + (this.altura * 2);
        }
    }
}
