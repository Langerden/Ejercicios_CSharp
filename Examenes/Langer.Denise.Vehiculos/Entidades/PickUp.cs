using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp() 
        {
            PickUp.valorHora = 50;
        }

        public PickUp(string patente, string modelo) : base (patente)
        {
            this.modelo = modelo;
        }
        
        public PickUp(string patente, string modelo, int valorHora) : this (patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Modelo: {this.modelo}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override string ImprimirTicket()
        {
            TimeSpan cantidadHoras = DateTime.Now.Subtract(this.ingreso);
            int costoEstadia = (int)cantidadHoras.TotalHours * PickUp.valorHora;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ConsultarDatos()}");
            sb.AppendLine($"Valor x Hora: {costoEstadia}");

            return sb.ToString();
        }
    }
}
