using System;

namespace Ejercicio_52
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(ConsoleColor color, string texto)
        {
            this.color = color;
            this.texto = texto;
        }
    }
}