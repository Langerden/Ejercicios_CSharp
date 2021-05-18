using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public enum Posicion
        {
            Arquero,
            Defensor,
            Central,
            Delantero
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura
        {
            get { return this.altura; }
        }

        public float Peso
        {
            get { return this.peso; }
        }

        public Posicion Posiciones
        {
            get { return this.posicion; }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine($"ALTURA: {this.Altura}");
            sb.AppendLine($"PESO: {this.Peso}");
            sb.AppendLine($"POSICION: {this.Posiciones}");
            return sb.ToString();
        }

        /// <summary>
        /// Un jugador será apto para ingresar a un equipo siempre que su edad no supere los 40 años y se encuentre en estado físico
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            if (this.Edad < 40 && ValidarEstadoFisico())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// deberá validar que el índice de masa corporal se encuentre en el rango de 18.5 y 25 inclusive. 
        /// Para calcularlo, utilizar la siguiente fórmula: IMC = peso / altura^2
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            bool valida = false;
            double alturaAlCuadrado = Math.Pow(Altura, 2);
            double imc = this.Peso / alturaAlCuadrado;

            if (imc >= 18.5f && imc <= 25.0f)
            {
                valida = true;
            }
            return valida;
        }
    }
}
