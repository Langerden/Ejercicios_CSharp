using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promediosGoles;
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

        public float GetPromedioGoles()
        {
            if (this.partidosJugados != 0)
            {
                this.promediosGoles = (float) this.totalGoles / this.partidosJugados;
            }
            return this.promediosGoles;            
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"DNI: {this.dni.ToString()} NOMBRE: {this.nombre.ToString()} PARTIDOS JUGADOS: {this.partidosJugados.ToString()} TOTAL GOLES: {this.totalGoles.ToString()}").ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}
