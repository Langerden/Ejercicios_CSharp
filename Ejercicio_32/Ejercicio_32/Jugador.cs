using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;            
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados != 0)
                {
                   return (float)this.totalGoles / this.partidosJugados;
                }
                else
                    return 0;
            }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"DNI: {this.Dni.ToString()} NOMBRE: {this.Nombre.ToString()} PARTIDOS JUGADOS: {this.PartidosJugados.ToString()} TOTAL GOLES: {this.TotalGoles.ToString()}").ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
    }
}
