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
    public class Serializer<T> : IArchivo<T>
    {
        public bool Guardar(string pathArchivo, T datos)
        {
            bool retorno = false;

            try
            {
                if (pathArchivo != null && (!(Directory.Exists(pathArchivo))))
                    using (XmlTextWriter auxWriter = new XmlTextWriter(pathArchivo, Encoding.UTF8))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        nuevoXml.Serialize(auxWriter, datos);
                        retorno = true;
                    }
            }
            catch (Exception)
            {
                throw new Exception($"Error al querer Guardar el archivo: {pathArchivo}.");
            }
            return retorno;
        }

        public bool Leer(string pathArchivo, out T datos)
        {
            bool retorno = false;
            datos = default;

            try
            {
                if (pathArchivo != null)
                {
                    using (XmlTextReader auxReader = new XmlTextReader(pathArchivo))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        datos = (T)nuevoXml.Deserialize(auxReader);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al querer Leer el achivo desde el archivo: {pathArchivo}.");
            }
            return retorno;
        }
    }
}
