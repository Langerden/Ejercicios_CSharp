using ComiqueriaLogic.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic
{
    public static class Serializador<T> where T : class, new()
    {
        public static bool GuardarBin(string pathArchivo, T datos)
        {
            bool retorno = false;
            try
            {
                if (pathArchivo != null)
                {
                    using (FileStream fileStream = new FileStream(pathArchivo, FileMode.OpenOrCreate))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fileStream, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no soy creativa :D", ex); 
            }
            return retorno;
        }

        public static bool LeerBin(string pathArchivo, out T datos)
        {
            bool retorno = false;
            datos = default;
            try
            {
                if (pathArchivo != null)
                {
                    using (FileStream fileStream = new FileStream(pathArchivo, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        datos = (T)formatter.Deserialize(fileStream);
                        retorno = true;
                    }
                }
            }
            catch (DirectoryNotFoundException dirEx)
            {
                ComiqueriaException exception = new ComiqueriaException("Error: Directorio no encontrado", dirEx);
                ArchivoTexto.Escribir(exception, true);
                throw exception;
            }

            catch (Exception ex)
            {

                throw new Exception("mensaje gracioso", ex);
            }
            return retorno;
        }

        public static bool GuardarXml(string pathArchivo, T datos)
        {
            bool retorno = false;

            try
            {
                if (pathArchivo != null && (Directory.Exists(pathArchivo)))
                {
                    using (XmlTextWriter auxWriter = new XmlTextWriter(pathArchivo, Encoding.UTF8))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        nuevoXml.Serialize(auxWriter, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al querer Guardar el archivo: {pathArchivo}.", ex);
            }
            return retorno;
        }

        public static bool LeerXml(string pathArchivo, out T datos)
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
            } catch (ArgumentException argEx)
            {
                throw new ArgumentException("Argument Exception", argEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al querer Leer el achivo desde el archivo: {pathArchivo}.", ex);
            }
            return retorno;
        }
    }
}
