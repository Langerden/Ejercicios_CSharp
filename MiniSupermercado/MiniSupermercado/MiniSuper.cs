using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermercado
{
    public static class MiniSuper
    {
        private static Usuario[] usuarios;
        static MiniSuper()
        {
            usuarios = new Usuario[0];
        }

        public static Usuario [] GetUsuarios()
        {
            return usuarios;
        }

        public static bool AgregarUsuario(Usuario usuario)
        {
            //todo Hacer sobrecarga de operadores para el == y el +=
            foreach (Usuario item in usuarios)
            {
                if (usuario == item)
                    return false;
            }

            Array.Resize<Usuario>(ref usuarios, usuarios.Length + 1);
            usuarios[usuarios.Length - 1] = usuario;
            //usuarios += usuario;
            return true;
        }
    }
}
