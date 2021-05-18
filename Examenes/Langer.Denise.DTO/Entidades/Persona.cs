using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        protected Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        public string Apellido
        {
            get { return apellido; }
        }       
        
        public string Nombre
        {
            get { return nombre; }
        }        
        
        public int Edad
        {
            get { return edad; }
        }        
        
        public int Dni
        {
            get { return dni; }
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {Nombre}");
            sb.AppendLine($"APELLIDO: {Apellido}");
            sb.AppendLine($"EDAD: {Edad}");
            sb.AppendLine($"DNI: {Dni}");
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
