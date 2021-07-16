using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Log : IArchivos
    {
        private static readonly string file = $"{AppDomain.CurrentDomain.BaseDirectory}\\Log.txt";

        public string Leer()
        {
            string text = string.Empty;
            if (!File.Exists(file))
            {
                throw new Exception("No existe el directorio o el archivo especificado");
            }
            else
            {
                using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
                {
                    text = reader.ReadToEnd();
                }
            }
            return text;
        }

        public bool Guardar()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file, true))
                {
                    writer.WriteLine($"Se disfrutó el gol del siglo a las {DateTime.Now}");
                    writer.WriteLine("-----------------------------------------------------------------------------------");
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
