using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        float UnidadEscritura { get; set; }

        EscrituraWrapper Escribir(string text);

        bool Recargar(int unidades);

    }
}
