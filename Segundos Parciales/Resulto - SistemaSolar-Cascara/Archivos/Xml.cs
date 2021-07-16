using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; }
        }


        public bool FileExist(string archivo)
        {
            return File.Exists(GetDirectoryPath + archivo);
        }

        public void Guardar(string nombreArchivo, T objeto)
        {

        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            string path = GetDirectoryPath + nombreArchivo;
            try
            {
                using (XmlTextWriter writter = new XmlTextWriter(path, encoding))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    serial.Serialize(writter, objeto);
                }
            }
            catch (Exception)
            {
                throw new ErrorArchivosException("Error al serializar el archivo");
            }
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            throw new NotImplementedException();
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            string path = GetDirectoryPath + nombreArchivo;
            objeto = default(T);
            bool retorno = false;

            try
            {
                if (this.FileExist(nombreArchivo))
                {
                    using (XmlTextReader reader = new XmlTextReader(path))
                    {
                        XmlSerializer serial = new XmlSerializer(typeof(T));
                        objeto = (T)serial.Deserialize(reader);
                        retorno = true;
                    }
                }
                return retorno;
            } catch (Exception)
            {
                throw new ErrorArchivosException("Error al deserializar el archivo");
            }
        }
    }
}
