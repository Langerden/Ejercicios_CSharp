using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Cartuchera2
    {
        public List<Lapiz> listaLapiz;
        public List<Boligrafo> listaBoligrafo;

        public Cartuchera2()
        {
            listaLapiz = new List<Lapiz>();
            listaBoligrafo = new List<Boligrafo>();
        }

        public bool ProbarElementosLapiz()
        {
            bool result = false;
            foreach (Lapiz item in this.listaLapiz)
            {
                if (item.UnidadEscritura == 0)
                    item.Recargar(20);
                else
                {
                    item.UnidadEscritura--;
                    result = true;
                }
            }
            return result;
        }
        public bool ProbarElementosBoligrafo()
        {
            bool result = false;
            foreach (Boligrafo item in this.listaBoligrafo)
            {
                if (item.UnidadEscritura < 0)
                    item.Recargar(20);
                else
                {
                    item.UnidadEscritura--;
                    result = true;
                }
            }
            return result;
        }
    }
}
