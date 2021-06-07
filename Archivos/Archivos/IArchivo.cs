using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IArchivo<T>
    {
        bool Guardar(string pathArchivo, T datos);
        bool Leer(string pathArchivo, out T datos);
    }
}
