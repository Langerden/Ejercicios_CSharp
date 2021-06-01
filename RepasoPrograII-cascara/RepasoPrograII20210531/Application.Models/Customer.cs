using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common;

namespace Application.Models
{
    public class Customer : Entity
    {
        private string name;
        private string lastName;
        private int age;
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public Customer()
        {

        }
        public Customer(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public static bool operator ==(List<Customer> customers, Customer customer)
        {
            bool response=false;
            foreach (Customer item in customers)
            {
                if (item.name == customer.name && item.lastName == customer.lastName && item.age == customer.age)
                {
                    response = true;
                }
            }

            return response;
        }

        public static bool operator !=(List<Customer> customers, Customer customer)
        {
            return !(customers == customer);
        }


    }
}
