using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set{
                throw new NotImplementedException();
            }
        }

        public float UnidadEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string text)
        {
            float cantidadReducir = (float)(text.Length * 0.1);
            UnidadEscritura -= cantidadReducir;
            return new EscrituraWrapper(Color, text);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
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
