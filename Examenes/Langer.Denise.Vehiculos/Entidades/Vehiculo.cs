using System;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        protected Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.patente = patente;
        }

        public string Patente
        {
            get { return this.patente; }
            set { if(this.patente.Length==6)
                    this.patente = value; }
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine($"Fecha ingreso: {this.ingreso}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return String.Format("Patente: {0}", Patente);
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            if (v1.patente.Equals(v2.patente))
                return true;
            else
                return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}