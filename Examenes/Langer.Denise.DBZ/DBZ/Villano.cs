using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZ
{
    public class Villano : Personaje
    {
        private bool maximoPoder;
        private Eorigen origen;


        protected override string Description
        {
            get { return "Soy Malísimo.Diabólico.Así como los profes de labo de la noche"; }
        }

        /// <summary>
        /// Este método, en caso de que la variable maximoPoder sea falsa, aumentara el valor de nivelPoder en un 80%, 
        /// cambiará el valor de la variable maximoPoder y devolverá el mensaje
        /// </summary>
        /// <returns></returns>
        public override string Transformarse()
        {
           if(maximoPoder == false)
            {
                this.nivelPoder *= (int) 0.8;
                this.maximoPoder = true;
                return "Poder aumentado al máximo";
            }
            else
            {
                return "El poder ya está al límite";
            }

        }

       public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.InfoPersonaje()}");
            sb.AppendLine($"Max Poder: {this.maximoPoder}");
            sb.AppendLine($"Origen: {this.origen}");
            return sb.ToString();
        }

        public Villano(string nombre, int nivelPoder, List<EHabilidad> ataque, Eorigen origen) : base(nombre,nivelPoder, ataque)
        {
            this.origen = origen;
        }
    }
}
