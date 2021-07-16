using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class ArchivoTexto
    {
        public static void Escribir(IArchivoTexto objetoInterfaz, bool append)
        {
            try
            {
                if (objetoInterfaz.Ruta != null && (!(string.IsNullOrWhiteSpace(objetoInterfaz.Ruta))))
                {

                    using (StreamWriter writer = new StreamWriter(objetoInterfaz.Ruta, append, Encoding.UTF8))
                    {
                        writer.WriteLine(objetoInterfaz.Texto);
                        writer.WriteLine("-----------------------------------------------------------------------------------");
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string Leer(IArchivoTexto objetoInterfaz)
        {
            string datos = string.Empty;
            if (File.Exists(objetoInterfaz.Ruta) && (!(string.IsNullOrWhiteSpace(objetoInterfaz.Ruta))))
            {
                using (StreamReader reader = new StreamReader(objetoInterfaz.Ruta))
                {
                    datos = reader.ReadToEnd();                    
                }
            }
            else
            {
                throw new FileNotFoundException("No se puede encontrar el archivo especificado");
            }
            return datos;
        }
    }
}

