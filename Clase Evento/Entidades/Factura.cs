using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        #region Atributos

        private float precio;
        private int numero;

        #endregion

        #region Propiedades

        public float Precio 
        {
            get 
            { 
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public int Numero 
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        #endregion

        #region Constructores
        public Factura()
        {

        }

        public Factura(float precio, int numero)
        {
            this.precio = precio;
            this.numero = numero;
        }

        #endregion
    }
}
