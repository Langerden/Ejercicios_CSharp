using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores
{
    public class Banano : Planta
    {
        private string codigo;

        public override bool TieneFores
        {
            get
            {
                return true;
            }
        }

        public override bool TieneFruta
        {
            get
            {
                return true;
            }
        }

        public Banano(string nombre, int tamanio, string codigo) : base(nombre,tamanio)
        {
            this.codigo = codigo;
        }

        public override string ResumenDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDatos());
            sb.Append($"Código internacional: {this.codigo}");
            return sb.ToString();
        }
    }
}
