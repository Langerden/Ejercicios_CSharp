using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Files.Text;

namespace Application.Helpers
{
    public static class Logger
    {
        private static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivo.txt";
        public static void LogException(string log)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Error: {log} Fecha: {DateTime.Now}");
                sw.WriteLine(sb.ToString());                
            }
        }
    }
}

            // TODO: implementar. Debe registara fecha,hora y mensaje de cada excepcion en un archivo de text, 
            //El archivo se tiene que guardar en el escritorio
            //throw new NotImplementedException();