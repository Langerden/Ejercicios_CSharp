using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
using Application.Files.Xml;
using System.Xml;
using System.Xml.Serialization;

namespace Application.DataAcces
{
    // <summary>
    // Servicio para deserializar y serializar un cliente
    // </summary>
    public class CustomerSerializer : Xml<List<Customer>>
    {
        private readonly string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\OtherCustomers.xml";

        public bool Save(List<Customer> customer)
        {
            return base.Save(this.path, customer);
        }

        public List<Customer> Read(string path)
        {
            List<Customer> customers = new List<Customer>();

            if (!base.Read(path, out customers))
            {
                throw new Exception("Error al deserializar el contenido del archivo");
                //TODO: implementar--> OK
            }
            return customers;
        }
    }
}
