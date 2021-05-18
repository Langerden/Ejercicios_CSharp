using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores
{
    public class Jardin
    {

        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        private int espacioTotal;
        private List<Planta> plantas;
        static Tipo suelo;

        public Tipo TipoSuelo
        {
            set { suelo = value; }
        }

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal) : this ()
        {
            this.espacioTotal = espacioTotal;
        }

        //e. EspacioOcupado retornará el espacio total ocupado por todas las plantas del Jardín.
        private int EspacioOcupado()
        {
            int result = 0;
            foreach(Planta item in plantas)
            {
                result += item.Tamanio;
            }
            return result;
        }

        //EspacioOcupado(Planta) retornará el total ocupado + el tamaño de la plata recibida como parámetro.
        private int EspacioOcupado(Planta planta)
        {
            return EspacioOcupado() + planta.Tamanio;
        }

         /// <summary>
        /// El operador + agregará siempre y cuando espacioTotal sea suficiente para agregar una nueva planta (espacio ocupado + tamaño de la planta).
        /// </summary>
        /// <param name="j"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator + (Jardin j, Planta p)
        {
            if (j.EspacioOcupado(p) <= j.espacioTotal)
            {
                j.plantas.Add(p);
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composición del Jardín: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine($"LISTA PLANTAS");
            foreach (Planta item in plantas)
            {
                sb.AppendLine(item.ResumenDatos());
            }
            return sb.ToString();
        }
    }
}
