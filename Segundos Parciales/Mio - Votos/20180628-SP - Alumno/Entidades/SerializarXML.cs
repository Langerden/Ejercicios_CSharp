using MisExcepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            bool retorno = false;

            try
            {
                if (rutaArchivo != null && (Directory.Exists(rutaArchivo)))
                {
                    using (XmlTextWriter auxWriter = new XmlTextWriter(rutaArchivo, Encoding.UTF8))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(Votacion));
                        nuevoXml.Serialize(auxWriter, objeto);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new ErrorArchivoExceptions($"Error al querer Guardar el archivo: {rutaArchivo}.");
            }
            return retorno;
        }

        public T Leer(string rutaArchivo)
        {
            T datos = default;

            try
            {
                if (rutaArchivo != null)
                {
                    using (XmlTextReader auxReader = new XmlTextReader(rutaArchivo))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        datos = (T)nuevoXml.Deserialize(auxReader);
                    }
                }
            }
            catch (Exception)
            {
                throw new ErrorArchivoExceptions($"Error al querer Leer el achivo desde el archivo: {rutaArchivo}.");
            }
            return datos;
        }
    }
}
