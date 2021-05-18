using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Division division;

        public Alumno(string nombre, string apellido, string documento, short anio, Division division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get { return this.anio.ToString() + "°" + this.division.ToString(); }
        }

        public string ExponerDato()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DATOS PERSONA: {base.ExponerDatos()} ANIO DIVISION: {this.AnioDivision}");
            return sb.ToString();
        }

        protected override bool ValidarDocumento(string doc)
        {
            if (doc.IndexOf('-') == 2 && doc.IndexOf('-') == 7)
                return true;
            else
                return false;
        }
        public enum Division
        {
            A,
            B,
            C,
            D,
            E
        }
    }
}
