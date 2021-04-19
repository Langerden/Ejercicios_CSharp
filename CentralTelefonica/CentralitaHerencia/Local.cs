using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        //La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        //Método Mostrar expondrá, además de los atributos de la clase base, la propiedad CostoLlamada. Utilizar StringBuilder.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} + COSTO: {this.CostoLlamada}");
            return sb.ToString();
        }

        //CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
    }
}
