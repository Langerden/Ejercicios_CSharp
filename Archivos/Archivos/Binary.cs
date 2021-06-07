using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Binary<T> : IArchivo<T>
    {
        public bool Guardar(string pathArchivo, T datos)
        {
            bool retorno = false;

            if (pathArchivo != null)
            {
                using(FileStream fileStream = new FileStream(pathArchivo, FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, datos);
                    retorno = true;
                }
            }
            return retorno;
        }

        public bool Leer(string pathArchivo, out T datos)
        {
            bool retorno = false;
            datos = default;

            if (pathArchivo != null)
            {
                using (FileStream fileStream = new FileStream(pathArchivo, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    datos = (T)formatter.Deserialize(fileStream);                    
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
