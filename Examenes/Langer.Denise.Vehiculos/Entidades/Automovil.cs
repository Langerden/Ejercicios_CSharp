using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil() 
        {
            Automovil.valorHora = 50;
        }

        public Automovil (string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }
        public Automovil (string patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Color: {this.color}");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {

            TimeSpan cantidadHoras = DateTime.Now.Subtract(this.ingreso);
            int costoEstadia = (int)cantidadHoras.TotalHours * Automovil.valorHora;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ConsultarDatos()}");
            sb.AppendLine($"Valor x Hora: {costoEstadia}");

            return sb.ToString();
        }
    }
}
