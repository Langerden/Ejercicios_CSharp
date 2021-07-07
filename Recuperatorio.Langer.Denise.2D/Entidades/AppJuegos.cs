using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos : Aplicacion
    {
        /// <summary>
        /// Constructor de la Clase AppJuegos
        /// </summary>
        /// <param name="nombre">Nombre que instancia el valor del objeto</param>
        /// <param name="sistemaOp">Sistema Op que instancia el valor del objeto</param>
        /// <param name="tamanioMB">Tamaño que instancia el valor del objeto</param>
        public AppJuegos(string nombre, Dispositivo.ESistemaOperativo sistemaOp, int tamanioMB) : base(nombre, sistemaOp, tamanioMB)
        {
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve el tamañoMb 
        /// </summary>
        protected override int Tamanio
        {
            get { return this.tamanioMB; }
        }
    }
}
