using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Dispositivo;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected ESistemaOperativo sistemaOp;
        protected int tamanioMB;

        /// <summary>
        /// Constructor de la Clase Aplicacion
        /// </summary>
        /// <param name="nombre">Nombre que instancia el valor del objeto</param>
        /// <param name="sistemaOp">Sistema Op que instancia el valor del objeto</param>
        /// <param name="tamanioMB">Tamaño que instancia el valor del objeto</param>
        protected Aplicacion(string nombre, ESistemaOperativo sistemaOp, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOp = sistemaOp;
            this.tamanioMB = tamanioMB;
        }

        /// <summary>
        /// Propiedad que devuelve el SO
        /// </summary>
        public ESistemaOperativo ESistemaOperativo
        {
            get { return this.sistemaOp; }
        }

        /// <summary>
        /// Propiedad abstracta para retornar el tamaño
        /// </summary>
        protected abstract int Tamanio
        {
            get;
        }

        /// <summary>
        /// Pperador implícito que recibe una lista de aplicaciones y devuelve la instancia de la aplicación que más tamaño tenga.
        /// </summary>
        /// <param name="listaApp">Lista con las aplicaciones</param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maxValue = int.MinValue;
            int index = 0;

            if (listaApp.Count >= 0)
            {
                for (int i = 0; i < listaApp.Count; i++)
                {
                    if (maxValue < listaApp[i].tamanioMB)
                    {
                        maxValue = listaApp[i].tamanioMB;
                        index = i;
                    }
                }
            }
            return listaApp[index];
        }

        /// <summary>
        /// Sobrecarga de operador == que buscará si la aplicación ingresada como parametro existe en la lista recibida por parámetro comparando por el nombre. 
        /// </summary>
        /// <param name="listaApp">Instancia de la lista de apps</param>
        /// <param name="app">Instancia de Aplicacion</param>
        /// <returns>Devuelve true si la app ya existe en la lista, en caso contrario devuelve false</returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (!(listaApp is null) && (!(app is null)) && listaApp.Count >= 0)
            {
                foreach (Aplicacion item in listaApp)
                {
                    if (item.nombre == app.nombre)
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operadaor !=. Reutiliza sobrecarga del operador ==
        /// </summary>
        /// <param name="listaApp">Instancia de la lista de apps</param>
        /// <param name="app">Instancia de Aplicacion</param>
        /// <returns>Devuelve true si la app ya existe en la lista, en caso contrario devuelve false</returns>
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// Sobrecarga del operador + que añadirá una aplicación a la lista de aplicaciones pasada por parámetro
        /// (siempre y cuando sea no exista previamente)
        /// </summary>
        /// <param name="listaApp">Instancia de la lista de apps</param>
        /// <param name="app">Instancia de Aplicacion</param>
        /// <returns>Devuelve true si la app es agregada a la lista o false en caso contrario</returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (!(listaApp is null) && (!(app is null)) && listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Devuelve todos los datos de la Aplicacion
        /// </summary>
        /// <returns>Retorna los datos de la aplicación</returns>
        public virtual string InfoApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"SO: {ESistemaOperativo}");
            sb.AppendLine($"TAMAÑO: {Tamanio}");
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve el nombre de la Aplicacion
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }



    }
}
