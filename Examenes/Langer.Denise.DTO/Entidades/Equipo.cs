using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaxJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// La propiedad DirectorTecnico será utilizada para asignar un director técnico al equipo siempre
        /// y cuando cumpla con las condiciones de aptitud.
        /// </summary>

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }


        public string Nombre
        {
            get { return this.nombre; }
        }

        /// <summary>
        /// retornará los datos del equipo, su director técnico 
        /// (en caso de no tener uno asignado aún, mostrar en su lugar el string "Sin DT asignado")
        /// y todos sus jugadores, utilizando StringBuilder para compilar dicha información.
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {e.Nombre}");
            sb.AppendLine($"Cantidad jugadores: { cantidadMaxJugadores}");

            foreach (Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }

            if (e.directorTecnico is null)
                sb.AppendLine("Sin DT asignado");
            else
                sb.AppendLine($"Director Tecnico: {e.directorTecnico.Nombre} {e.directorTecnico.Apellido}");
            return sb.ToString();
        }

        /// <summary>
        /// Informará true si esa instancia de Jugador ya se encuentra agregada al equipo.
        /// </summary>
        /// <param name="e"> Instancia Equipo </param>
        /// <param name="j"> Instancia Jugador</param>
        /// <returns>True si esa instancia de Jugador ya se encuentra agregada al equipo.</returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool resultado = false;

            if (e.jugadores.Contains(j))
            {
                resultado = true;
            }
            return resultado;
        }


        /// <summary>
        /// Informará true si esa instancia de Jugador no se encuentra agregada al equipo.
        /// </summary>
        /// <param name="e"> Instancia Equipo </param>
        /// <param name="j"> Instancia Jugador</param>
        /// <returns>False si esa instancia de Jugador ya se encuentra agregada al equipo.</returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        /// <summary>
        /// El operador + entre Equipo y Jugador agregará el jugador al equipo siempre y cuando:
        /// i.Este no haya sido agregado aún.
        /// ii.No haya sido superada la cantidad de integrantes.
        /// iii.Cumpla las condiciones de aptitud.
        /// </summary>
        /// <param name="e"> Instancia de Equipo</param>
        /// <param name="j"> Instancia de Jugador</param>
        /// <returns></returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
            {
                if (Equipo.cantidadMaxJugadores <= 6)
                {
                    if (j.ValidarAptitud())
                    {
                        e.jugadores.Add(j);
                    }
                }
            }
            return e;
        }

        /// <summary>
        /// ValidarEquipo: Retorna true en caso de que un equipo sea válido
        /// </summary>
        /// <param name="e"> Instancia de Equipo</param>
        /// <returns></returns>
        public static bool ValidarEquipo(Equipo e)
        {
            int countArq = 0;
            int countDef = 0;
            int countCen = 0;
            int countDel = 0;

            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador.Posiciones is Jugador.Posicion.Arquero)
                    countArq++;
                else if (jugador.Posiciones is Jugador.Posicion.Defensor)
                    countDef++;
                else if (jugador.Posiciones is Jugador.Posicion.Central)
                    countCen++;
                else if (jugador.Posiciones is Jugador.Posicion.Delantero)
                    countDel++;
            }

            if (e.directorTecnico != null && countArq == 1 && countDef >= 1 && countCen >= 1 && countDel >= 1 && e.jugadores.Count == cantidadMaxJugadores)
                return true;
            else
                return false;
        }
    }
}
