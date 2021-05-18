using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(ConsoleColor colorTinta, float tinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        //i. Escribir reducirá la tinta en 0.3 por cada carácter escrito.
        public EscrituraWrapper Escribir(string text)
        {
            float cantidadReducir = (float)(text.Length * 0.3);
            UnidadEscritura -= cantidadReducir;
            return new EscrituraWrapper(Color, text);
        }        
        
        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                UnidadEscritura += unidades;
                return true;
            } else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Color Tinta: {Color}");
            sb.AppendLine($"Cantidad de Tinta: {UnidadEscritura}");
            sb.AppendLine($"Entidad: {this.GetType().Name}");
            return sb.ToString();
        }

    }
}
