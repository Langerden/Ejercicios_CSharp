using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Alumno.Division division;
        private Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Alumno.Division division, Profesor profesor) : this ()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        public string AnioDivision
        {
            get { return this.anio.ToString() + "°" + this.division.ToString(); }
        }


        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"AÑO: {c.anio} DIVISION: {c.division} Profesor: {c.profesor.ExponerDato()}");
            foreach (Alumno item in c.alumnos)
            {
                sb.Append(item.ExponerDato());
            }
            return sb.ToString();
    }

        public static bool operator == (Curso c, Alumno a)
        {
            bool result = false;
            foreach (Alumno item in c.alumnos)
            {
                if (item.AnioDivision.Equals(a.AnioDivision))
                    result = true;
            }
            return result;
        }
        public static bool operator != (Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            foreach (Alumno item in c.alumnos)
            {
                if (c == a)
                {
                    c.alumnos.Add(a);
                }
            }
            return c;
        }
    }
}
