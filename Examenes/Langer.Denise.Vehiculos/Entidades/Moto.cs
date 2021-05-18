using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            Moto.valorHora = 30;   
        }

        public Moto(string patente, int cilindrada) : base (patente)
        {
            this.cilindrada = cilindrada;            
            this.ruedas = 2;

        }
        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }        
        
        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Cilindros: {this.cilindrada}");
            sb.AppendLine($"Ruedas: {this.ruedas}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        /// <summary>
        /// El método ImprimirTicket de las siguientes clases agregará a la información descripta en Vehiculo el costo de la estadía, 
        /// siendo este el resultado de la cantidad de horas desde su ingreso hasta ahora * el valor de la hora.
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            TimeSpan cantidadHoras = DateTime.Now.Subtract(this.ingreso);
            int costoEstadia = (int) cantidadHoras.TotalHours * Moto.valorHora;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ConsultarDatos()}");
            sb.AppendLine($"Valor x Hora: {costoEstadia}");
            return sb.ToString();
        }
    }
}
