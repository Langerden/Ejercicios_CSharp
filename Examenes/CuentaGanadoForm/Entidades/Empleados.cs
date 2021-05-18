using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados : Persona
    {
        private int dni;

        public Empleados(short edad, string nombre) : this(edad, nombre, -1) {
        }

        public Empleados(short edad, string nombre, int dni) : base(edad,nombre)
        {
            this.dni = dni;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            if (this.dni != -1)
            {
                sb.Append($"DNI: {this.dni}");
            }
            else
            {
                sb.Append("No se cargó un empleado");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Chequea que la edad sea mayor a 21 años y que el nombre tenga al menos 2 caracteres.
        /// </summary>
        /// <returns></returns>
        public override bool Validar()
        {
            return this.Edad >= 21 && this.Nombre.Length >= 2;
        }

        public static bool operator == (Empleados e1, Empleados e2)
        {
            return e1.Edad == e2.Edad && e1.Nombre.Equals(e2.Nombre);                
        }

        public static bool operator !=(Empleados e1, Empleados e2)
        {
            return !(e1 == e2);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
