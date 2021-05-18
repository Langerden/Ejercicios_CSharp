using System.Collections.Generic;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        private Cantina(int espaciosTotales)
        {
            this.espaciosTotales = espaciosTotales;
            botellas = new List<Botella>();
        }

        public List<Botella> Botellas
        {
            get
            {
                return botellas;
            }
        }

        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
                return Cantina.singleton = new Cantina(espacios);
            else
            {
                singleton.espaciosTotales = espacios;
                return Cantina.singleton;
            }
        }

        public static bool operator +(Cantina c, Botella b)
        {
            bool resultado = false;

            if (c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                resultado = true;

            }
            return resultado;
        }
    }
}
