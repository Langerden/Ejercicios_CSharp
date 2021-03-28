using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta (short tinta)
        {
            short valorActual = GetTinta();
            if ((valorActual + tinta) >= 0 && (valorActual + tinta) <= cantidadTintaMaxima)
                this.tinta = (short)(valorActual + tinta);
            else if (valorActual + tinta < 0)
                this.tinta = 0;
            else
                this.tinta = cantidadTintaMaxima;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar (short gasto, out string dibujo)
        {
            dibujo = "";
            if (GetTinta() > 0 && gasto < 0)
            {
                this.SetTinta(gasto);
                return true;
            }
            else
            { 
                return false;
            }
        }
        public string PrintGasto (int tintaActual)
        {
            string asterisco = "";

            if (tintaActual <= 0)
                asterisco = "No hay mas tinta";
            else {
                for (int i = 0; i < tintaActual; i++)
                {
                    if (i % 10 == 0)
                        asterisco += "\n";
                    asterisco += "*";
                }
            }
            return asterisco;
        }
    }
}
