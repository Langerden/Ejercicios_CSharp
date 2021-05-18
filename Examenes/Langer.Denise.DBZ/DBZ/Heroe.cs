using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZ
{
    public class Heroe : Personaje
    {
        private bool esSaiayin;
        private ESaiayin transformacion;


        /// <summary>
        /// Descripción: Es una propiedad de tipo string que devolverá:
        /// i.Si es saiyan: "Disfruta los combates. Su poder no tiene limite"
        /// ii.Si no lo es: "Siempre pelea junto a un Saiyan.Fiel amigo"
        /// </summary>
        protected override string Description
        {
            get {
                if (esSaiayin)
                    return "Disfruta los combates.Su poder no tiene limite";
                else
                    return "Siempre pelea junto a un Saiyan.Fiel amigo";
            }
        }

        public Heroe(string nombre, int nivelPoder, List<EHabilidad> ataque, bool esSaiayin) : base(nombre, nivelPoder, ataque)
        {
            this.esSaiayin = esSaiayin;
        }

        public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.InfoPersonaje()}");
            sb.AppendLine($"Es Sayayin: {this.esSaiayin}");
            sb.AppendLine($"Transformacion: {this.transformacion}");
            return sb.ToString();
        }

        public override string Transformarse()
        {
            string result;
            if (this.esSaiayin)
            {
                result = "Transformacion actual: " + this.transformacion.ToString();

                switch (this.transformacion)
                {
                    case ESaiayin.Base:
                        this.nivelPoder = 100;
                        this.transformacion++;
                        break;
                    case ESaiayin.SSJ:
                        this.nivelPoder *= 10;
                        this.transformacion++;
                        break;
                    case ESaiayin.SSJ2:
                        this.nivelPoder *= 20;
                        this.transformacion++;
                        break;
                    case ESaiayin.SSJ3:
                        this.nivelPoder *= 30;
                        this.transformacion = ESaiayin.Base;
                        break;
                }
            } else
            {
                result = "No es un sayayin";
            }
            return result;
        }
    }
}
