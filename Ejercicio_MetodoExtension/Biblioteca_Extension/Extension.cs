using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Extension
{
    public static class Extension
    {
        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estaciones)
        {
            DateTime fechaEstacion = new DateTime(); 
            int diferencia = 0;

            switch (estaciones)
            {
                case Estaciones.Invierno:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 6,21);
                    break;
                case Estaciones.Primavera:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 9, 21);
                    break;               
                case Estaciones.Verano:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 12, 21);
                    break;                
                case Estaciones.Otonio:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 3, 21);
                    break;
            }

            if (fechaEstacion < fecha)
            {
                fechaEstacion = fechaEstacion.AddYears(1);
            }

            diferencia = (int)(fechaEstacion - fecha).TotalDays;

            //return $"Faltan {diferencia} dias para el {estaciones}";
            return $"Faltan {diferencia} dias para el {Enum.GetName(typeof(Estaciones), estaciones)}";
        }
    }
}
