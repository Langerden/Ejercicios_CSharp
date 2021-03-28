using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;

        public string GetNombreCompleto()
        {   
            //Inyectar un String
            return $"{this.nombre}{this.apellido}";
        }
    }
}
