using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set { this.añosExperiencia = value; }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine($"AÑOS EXPERIENCIA: {this.AñosExperiencia}");
            return sb.ToString();
        }

        /// <summary>
        /// validará que el Director Técnico sea menor a 65 años y tenga al menos 2 años de experiencia.
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            if (this.Edad < 65 && this.AñosExperiencia >= 2)
                return true;
            else
                return false;
        }
    }
}
