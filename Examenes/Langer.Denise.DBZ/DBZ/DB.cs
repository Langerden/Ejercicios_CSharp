using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBZ
{
    public static class DB
    {
        static List<Personaje> personajes;

        static DB()
        {
            personajes = new List<Personaje>();
        }

        public static List<Personaje> GetPersonajes
        {
            get { return personajes; }
        }
        public static bool AgregarPersonaje (Personaje p1)
        {
            if(p1 != personajes)
            {
                personajes.Add(p1);
                return true;
            } else
            {
                return false;
            }
        }

        public static void CargarDatos()
        {
            
        }

        //Recibirá el índice del personaje seleccionado en el ListBox, y dentro retornará la información completa de ese personaje.
        public static string GetInfoPersonaje(int index)
        {
            return personajes.ElementAt(index).InfoPersonaje();
        }

    }
}
