using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private bool esAdmin;

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido) : this(nombre,apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido, bool esAdmin) : this(nombre, apellido)
        {
            this.esAdmin = esAdmin;
        }

        public Persona(int id, string nombre, string apellido, bool esAdmin) : this(id, nombre, apellido)
        {
            this.esAdmin = esAdmin;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }        
        
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }        
        
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public bool EsAdmin
        {
            get { return this.esAdmin; }
            set { this.esAdmin = value; }
        }
    }
}
