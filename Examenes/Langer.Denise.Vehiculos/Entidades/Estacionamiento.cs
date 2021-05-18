using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();   
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
            this.nombre = nombre;
        }

        public static explicit operator string (Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Espacio Disponible: {e.espacioDisponible}");
            sb.AppendLine($"Nombre: {e.nombre}");

            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }

            return sb.ToString();
        }

        public static bool operator != (Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static bool operator == (Estacionamiento e, Vehiculo v)
        {
            bool resultado = false;
            foreach (Vehiculo item in e.vehiculos)
            {
                if (item == v)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Al quitar un Vehiculo de la lista se retornará el ticket de cobro mediante el método ImprimirTicket. 
        /// Caso contrario el método retornará: "El vehículo no es parte del estacionamiento".
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static string operator - (Estacionamiento e, Vehiculo v)
        {
            string resultado = "El vehículo no es parte del estacionamiento";
            
            if (e == v)
            {
                e.vehiculos.Remove(v);
                resultado = v.ImprimirTicket();
            }
            return resultado;
        }


        /// <summary>
        /// Se agregará un Vehiculo a la lista (+) siempre y cuando este:
        /// i.No figure previamente en la lista de Vehiculos.
        /// ii.Tenga una patente asignada.
        /// iii.La cantidad de espacio disponible del estacionamiento sea mayor a la cantidad de Vehiculos en la lista.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Estacionamiento operator + (Estacionamiento e, Vehiculo v)
        {
            if (e != v)
            {
                if (v.Patente != null)
                {
                    if (e.vehiculos.Count() < e.espacioDisponible)
                    {
                        e.vehiculos.Add(v);
                    }
                }
            }
            return e;
        }
    }
}
