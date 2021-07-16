using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Comercio : IBackup
    {

        private List<Cliente> clientes;

        /// <summary>
        /// Constructor que instancia la lista de clientes
        /// </summary>
        public Comercio()
        {
            this.clientes = new List<Cliente>();
        }

        /// <summary>
        /// Propiedad de Lectura y Escritura para la lista de Clientes
        /// </summary>
        public List<Cliente> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }

        /// <summary>
        /// Metodo que recorrerá el primer cliente que se encuentra dentro de la lista y luego lo remueve
        /// </summary>
        /// <returns>El primer cliente de la lista</returns>
        public Cliente LlamarCliente()
        {
            Cliente aux = new Cliente();

            if (this.Clientes.Count == 0)
            {
                throw new SinClientesExcepcion();
            }
            else
            {
                aux = this.Clientes.ElementAt(0);
                this.Clientes.RemoveAt(0);
            }
            return aux;
        }

        /// <summary>
        /// Metodo que lee un archivo con extension xml en formato de Lista de Clientes
        /// </summary>
        /// <param name="path"></param>
        public void LoadBackup(string path)
        {
            List<Cliente> auxList = new List<Cliente>();
            try
            {
                if (File.Exists(path))
                {
                    using (XmlTextReader auxReader = new XmlTextReader(path))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(List<Cliente>));
                        auxList = (List<Cliente>)nuevoXml.Deserialize(auxReader);
                    }
                }
                this.Clientes = auxList;
            }
            catch (Exception)
            {
                throw new Exception($"Error al querer Leer el achivo desde el archivo: {path}.");
            }
        }

        /// <summary>
        /// Metodo que guarda una lista de clientes en un archivo con extension xml
        /// </summary>
        /// <param name="path"></param>
        public void SaveBackup(string path)
        {
            List<Cliente> auxList = this.Clientes;
            try
            {

                using (XmlTextWriter auxWriter = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer nuevoXml = new XmlSerializer(typeof(List<Cliente>));
                    nuevoXml.Serialize(auxWriter, auxList);
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error al querer Guardar el archivo: {path}.");
            }
        }

        /// <summary>
        /// Sobrecarga del operador +. Settea el numero del cliente:
        /// Si es el primero, se settea por default un 1. En caso contarario se settea el numero siguiente (de forma incremental).
        /// Por ultilmo agrega el cliente a la lista.
        /// </summary>
        /// <param name="co">Comercio</param>
        /// <param name="cl">Instancia de Cliente</param>
        /// <returns></returns>
        public static Comercio operator +(Comercio co, Cliente cl)
        {
            int numero = 1;
            if (co.clientes.Count == 0)
            {
                cl.Numero = numero;
            }
            else
            {
                numero = co.clientes.Count + 1;
                cl.Numero = numero;
            }
            co.clientes.Add(cl);
            return co;
        }
    }
}
