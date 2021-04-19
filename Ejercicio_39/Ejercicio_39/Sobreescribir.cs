using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    public abstract class Sobreescribir
    {
        protected string miAtributo;

        public Sobreescribir ()
        {
            this.miAtributo = "Probar abstractos";
        }

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        //Sobreescribir el método Equals para que retorne true si son del mismo tipo(objetos de la misma clase), false en caso contrario.
        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        //Agregará propiedad abstracta MiPropiedad de sólo lectura.
        //Una vez implementada, retornará el valor de miAtributo.
        public abstract string MiPropiedad { get; }

        //Crear un método abstracto MiMetodo que retorne un string.
        //Una vez implementada, retornará el valor de MiPropiedad.
        public abstract string MiMetodo();

    }
}
