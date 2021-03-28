using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vacuna
    {
        private string nombre;

        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        { return this.nombre; }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }

}
