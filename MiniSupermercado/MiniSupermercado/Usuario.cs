using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermercado
{
    public class Usuario
    {
        string apellido;
        string nombre;
        long dni;
        string[] formasPago;
        string formaPago;
        string provincia;
        
        public Usuario(string apellido, string nombre, long dni, string[] formasPago, string formaPago, string provincia)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.formasPago = formasPago;
            this.formaPago = formaPago;
            this.provincia = provincia;
        }
        private string mostrarNombres()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.apellido);
            sb.Append(this.nombre);
            sb.Append(this.dni);
            sb.Append(this.formaPago);
            foreach (string item in this.formasPago)
            {
                sb.Append(item);
            }
            sb.Append(this.provincia);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.mostrarNombres();
        }
    }
}
