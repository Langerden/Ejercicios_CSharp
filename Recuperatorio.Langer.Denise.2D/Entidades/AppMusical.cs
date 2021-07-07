using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        /// <summary>
        /// Sobrecarga del constructor de la Clase AppMusical
        /// </summary>
        /// <param name="nombre">Nombre que instancia el valor del objeto</param>
        /// <param name="sistemaOp">Sistema Op que instancia el valor del objeto</param>
        /// <param name="tamanioMB">Tamaño que instancia el valor del objeto</param>
        /// <param name="listaCanciones">Lista a instanciar</param>
        public AppMusical(string nombre, Dispositivo.ESistemaOperativo sistemaOp, int tamanioMB, List<string> listaCanciones) : this(nombre, sistemaOp, tamanioMB)
        {
            this.listaCanciones = listaCanciones;
        }

        /// <summary>
        /// Constructor de la Clase AppMusical
        /// </summary>
        /// <param name="nombre">Nombre que instancia el valor del objeto</param>
        /// <param name="sistemaOp">Sistema Op que instancia el valor del objeto</param>
        /// <param name="tamanioMB">Tamaño que instancia el valor del objeto</param>
        public AppMusical(string nombre, Dispositivo.ESistemaOperativo sistemaOp, int tamanioMB) : base(nombre, sistemaOp, tamanioMB)
        {
            this.listaCanciones = new List<string>();
        }

        /// <summary>
        /// Devuelve todos los datos de la AppMusical
        /// </summary>
        /// <returns>Retorna los datos de la AppMusical</returns>
        public override string InfoApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Datos de la APP Musical\n");
            sb.AppendLine(base.InfoApp());
            foreach (String item in this.listaCanciones)
            {
                sb.AppendLine($"Cancion: {item}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Propiedad Tamanio retorna el tamaño de la app, 
        /// el cual crece en base a la cantidad de canciones que tenga cargada. 
        /// Por cada canción cargada, su tamaño crece en 2mb más.
        /// </summary>
        protected override int Tamanio
        {
            get { return (this.tamanioMB + (this.listaCanciones.Count * 2)); }
        }
    }
}
