using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        public Gente(short edad):base (edad, "")
        {
            base.Edad = edad;
        }
        public Gente(short edad, string nombre): base (edad,nombre)
        {
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ES GENTE");
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }
        public override bool Validar()
        {
            return this.Edad > 18;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
