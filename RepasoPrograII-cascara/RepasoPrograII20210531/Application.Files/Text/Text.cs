using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Files.Text
{
    public class Text<T> : IFile<string>
    {
        //TODO implementar IFile --> OK
        //private readonly string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";

        public bool Read(string file, out string data)
        {
            bool readData = false;
            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    data = reader.ReadToEnd();
                    readData = true;
                }
            }
            else
            {
                throw new FileNotFoundException("No se puede encontrar el archivo especificado");
            }
            return readData;
        }

        public bool Save(string file, string data)
        {
            bool saveData = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine(data);
                    saveData = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al escribir el archivo");
            }
            return saveData;
        }
    }
}
