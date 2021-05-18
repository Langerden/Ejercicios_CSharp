using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores
{
   public class Rosal : Planta
    {
        public enum Color
        {
            Roja,Blanca,Amarila,Rosa,Azul

        }

        private Color florColor;

        public override bool TieneFores {
            get {
                return true;
            }
        }

        public override bool TieneFruta
        {
            get
            {
                return false;
            }
        }

        public Rosal(string nombre, int tamanio) : base(nombre,tamanio)
        {

        }       
        
        public Rosal(string nombre, int tamanio, Color color) : this(nombre,tamanio)
        {
            this.florColor = color;
        }


        public override string ResumenDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDatos());
            sb.AppendLine($"Color: {this.florColor}");
            return sb.ToString();
        }
    }
}
