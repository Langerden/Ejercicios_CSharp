using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    public class Cartuchera1
    {
        public List<IAcciones> listaAcciones;

        public Cartuchera1()
        {
            this.listaAcciones = new List<IAcciones>();
        }

        /*Crear el método ProbarElementos
i. Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
ii. Cuando sea necesario, recargará antes de salir del método (cargar 20 unidades).
iii. Retornará true si todos los bolígrafos pudieron gastar exactamente las 1 unidades.*/

        public bool ProbarElementos()
        {
            bool result = false;
            foreach (IAcciones item in this.listaAcciones)
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
    }
}
