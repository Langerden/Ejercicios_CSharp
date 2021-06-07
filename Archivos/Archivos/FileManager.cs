using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class FileManager<T> : IArchivo<string>
    {
        public bool Guardar(string pathArchivo, string datos)
        {
            bool agregoInfo = false;
            try
            {
                if (pathArchivo != null)
                {
                    using (StreamWriter writer = new StreamWriter(pathArchivo))
                    {
                        writer.WriteLine(datos);
                        writer.WriteLine("-----------------------------------------------------------------------------------");
                        agregoInfo = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return agregoInfo;
        }

        public bool Leer(string pathArchivo, out string datos)
        {
            bool agregoInfo = false;
            datos = default;

            if (File.Exists(pathArchivo) && (!(string.IsNullOrWhiteSpace(pathArchivo))))
            {
                using (StreamReader reader = new StreamReader(pathArchivo))
                {
                    datos = reader.ReadToEnd();
                    agregoInfo = true;
                }
            }
            else
            {
                throw new FileNotFoundException("No se puede encontrar el archivo especificado");
            }

            return agregoInfo;
        }
    }
}
