using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleados> empleados;
        private List<Gente> gente;
        private static Bar singleton;


        static Bar()
        {
            singleton = new Bar();
        }

        public List<Empleados> Empleados
        {
            get { return this.empleados; }
        }

        public List<Gente> Gente
        {
            get { return this.gente; }
        }
        private Bar()
        {
            this.empleados = new List<Empleados>() { new Empleados(20,"Lucas"), new Empleados(50,"Facu"), new Empleados(25, "Denu")};
            this.gente = new List<Gente>() { new Gente(15), new Gente(54), new Gente(26, "Goku")};
        }

        public static Bar GetBar()
        {
            if(singleton is null)
            {
                singleton = new Bar();
            }

            return singleton;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DEL BAR");
            foreach (Empleados item in empleados)
            {
                sb.AppendLine(item.ToString());
            }

            foreach (Gente item in gente)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        
        public static bool operator + (Bar b, Empleados e)
        {
            if (e.Validar())
            {
                foreach (Empleados item in b.Empleados)
                {
                    if(item != e)
                    {
                        b.empleados.Add(e);
                        return true;
                    }

                }
            } 
          return false;
        }

        public static bool operator +(Bar b, Gente g)
        {
            int cantGentePosible = b.empleados.Count * 10;

            if (b.Gente.Count < cantGentePosible & g.Validar())
            {
                b.Gente.Add(g);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


