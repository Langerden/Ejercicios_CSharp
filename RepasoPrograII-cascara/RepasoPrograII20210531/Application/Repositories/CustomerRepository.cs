using System;
using System.Collections.Generic;
using System.Linq;
using Application.Exceptions;
using Application.DataAcces;
using Application.Models;

namespace Application.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        private static List<Customer> customers;

        #region -- Los datos no se encuentran guardados más que en memoria --

        static CustomerRepository()
        {
            // Carga de 100 clientes de forma predeterminada
            customers = new List<Customer>();

            for (int i = 0; i < 20; i++)
            {
                var customer = new Customer();
                customer.Id = i + 1;
                customer.Name = "CustomerName" + customer.Id;
                customer.LastName = "CustomerLastname" + customer.Id;
                customer.Age = 20 + (int)customer.Id;

                customers.Add(customer);
            }
        }

        #endregion

        public override void Create(Customer entity)
        {
            try
            {
                long lastId = (long)(customers[customers.Count - 1]).Id;
                entity.Id = lastId + 1;
                if (customers != entity)
                {
                    customers.Add(entity);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new TechnicalException(
                    string.Format("No se pudo crear el cliente \"{0} {1}\".", entity.Name, entity.LastName),
                    ex);
            }

        }

        public override List<Customer> GetAll()
        {
            return customers.OrderBy(customer => customer.Id).ToList();
        }
        public List<Customer> GetAll(string path)
        {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            customers.AddRange(customerSerializer.Read(path));
            return customers;
        }

        // TODO: implementar --> Ok
        public override Customer GetById(long entityId)
        {
            Customer aux = new Customer();
            foreach (Customer item in customers)
            {
                if(item.Id == entityId)
                {
                    aux = item;
                    break;
                }
            }
            return aux;
            //throw new NotImplementedException();
        }

        // TODO: implementar --> Ok
        public override void Remove(Customer entity)
        {
            if(customers.Contains(entity))
                customers.Remove(entity);
            //throw new NotImplementedException();
        }

        public override void Update(Customer entity)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if(customers[i].Id == entity.Id)
                {
                    Customer aux = new Customer(entity.Name, entity.LastName, entity.Age);                    
                    customers.Insert(i, aux);
                    break;
                }

            }

            // TODO: implementar --> OK
            //throw new NotImplementedException();
        }

        public List<Customer> LoadFromFile(string path)
        {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            customers.AddRange(customerSerializer.Read(path));
            return customers;
        }

        public bool SaveToFile(List<Customer> customers)
        {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            return customerSerializer.Save(customers);
        }
    }
}
