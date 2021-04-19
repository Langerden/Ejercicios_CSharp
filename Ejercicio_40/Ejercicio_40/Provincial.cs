using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public sealed class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        //Método Mostrar expondrá, además de los atributos de la clase base, la propiedad CostoLlamada y franjaHoraria. Utilizar StringBuilder
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} + COSTO: {this.CostoLlamada} + FRANJA HORARIA: {this.franjaHoraria}");
            return sb.ToString();
        }

        //CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
        //Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
        private float CalcularCosto()
        {
            float costo = 0;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                costo = 0.99F;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                costo = 1.25F;
            }
            else
            {
                costo = 0.66F;
            }

            return base.Duracion * costo;
        }
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }

}
