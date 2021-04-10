using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;


        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this ()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator == (Competencia c, AutoF1 f)
        {
            bool equals = false;
            foreach (AutoF1 autoF1 in c.competidores)
            {
                if (c.competidores.Contains(f))
                {
                    equals = true;
                    break;
                }
            }
            return equals;
        }

        public static bool operator != (Competencia c, AutoF1 f)
        {
            return !(c == f);
        }


        public static bool operator +(Competencia c, AutoF1 f)
        {
            bool result = false;
            Random random = new Random();
            if (c.cantidadCompetidores > 0 && c.competidores.Count < c.cantidadCompetidores)
            {
                if (c != f)
                {
                    f.EnCompetencia = true;
                    f.VueltasRestantes = c.cantidadVueltas;
                    f.CantidadCombustible = (short) random.Next(15, 100);
                    c.competidores.Add(f);
                    result = true;
                }
            }
            return result;
        }

        public static bool operator -(Competencia c, AutoF1 f)
        {
            bool result = false;

            if (c.competidores.Contains(f))
            {
                c.competidores.Remove(f);
                result = true;
            }
            return result;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CANTIDAD COMPETIDORES: {this.cantidadCompetidores}, VUELTAS: {this.cantidadVueltas}");
            foreach(AutoF1 f1 in this.competidores)
            {
                sb.AppendLine($"COMPETIDORES: {f1}");
            }
            return sb.ToString();
        }
    }
}
