using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, string telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public Cliente(string domicilio, string nombre, string apellido, string telefono, Mascota[] mascotas) : this(domicilio, nombre, apellido, telefono)
        {
            this.mascotas = mascotas;
        }

        public void AgregarMascota(Mascota mascota)
        {
            if (this.mascotas is null)
            {
                this.mascotas = new Mascota[1];
            }
            else
            {
                int nuevaCapacidad = this.mascotas.Length + 1;
                Array.Resize(ref this.mascotas, nuevaCapacidad);
            }
            for (int i = 0; i < this.mascotas.Length; i++)
            {
                if (this.mascotas[i] is null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"CLIENTE \nNombre: { this.nombre}, Domicilio:  {this.domicilio}, Apellido: {this.apellido}, Telefono: {this.telefono}\n";
            if (this.mascotas != null)
            {
                retorno += "MASCOTAS: \n";
                foreach (Mascota mascota in this.mascotas)
                {
                    if (mascota != null)
                        retorno += mascota.MostrarDatos();
                }
            }
            return retorno;
        }
    }
}
