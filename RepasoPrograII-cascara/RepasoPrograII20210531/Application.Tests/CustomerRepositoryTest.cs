using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Application.Repositories;
using Application.Models;

namespace Application.Tests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateSuccessfullyTest()
        {
            //Arrange
            CustomerRepository repository = new CustomerRepository();

            int millisecond = DateTime.Now.Millisecond;

            Customer entityToCreate = new Customer()
            {
                LastName = "TestCustomerLastName" + millisecond,
                Name = "TestCustomerName" + millisecond
            };
            //Notar que entityToCreate.Id es null en este momento

            //Act
            repository.Create(entityToCreate);

            Customer entityToValidate =
                repository.GetById(entityToCreate.Id);

            //Assert
            Assert.IsNotNull(entityToValidate);
            Assert.IsTrue(entityToValidate.Id > 0);
        }

        ///// <summary>
        /////A test for GetAll
        /////</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada
            List<Customer> actual;

            //Act
            actual = target.GetAll();

            //Assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count == 20);
        }

        ///// <summary>
        /////A test for GetById
        /////</summary>
        [TestMethod()]
        public void GetByIdTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository();
            long entityId = 1;
            Customer expected = new Customer("CustomerName1", "CustomerLastname1", 21); // TODO: Inicializar de manera apropiada 
            Customer actual;

            //Act
            actual = target.GetById(entityId);

            //Assert
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
        ///// <summary>
        /////A test for Remove
        /////</summary>
        [TestMethod()]
        public void RemoveTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada 
            Customer entity = new Customer();// TODO: Inicializar de manera apropiada
            entity.Id = 1;
            target.Remove(entity);            

            //Act

            //Assert            
            Assert.IsFalse(target.GetAll().Contains(entity));
        }
        ///// <summary>
        /////A test for Update
        /////</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada 
            Customer entity = target.GetById(1); // TODO: Inicializar de manera apropiada 

            //Act
            target.Update(entity);

            //Assert
            Assert.IsTrue(target.GetAll().Contains(entity));
        }
    }
}
