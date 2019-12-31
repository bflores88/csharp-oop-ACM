using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "bBaggins@hobbit.me"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "bBaggins@hobbit.me",
                AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        StreetLine1 = "Meow meow",
                        StreetLine2 = "Woof woof",
                        City = "Somewhere",
                        State = "Out there",
                        Country = "Neverland",
                        PostalCode = "1234"
                    },

                    new Address(2)
                    {
                        AddressType = 1,
                        StreetLine1 = "Bork bork",
                        StreetLine2 = "Maw maw",
                        City = "Over",
                        State = "There",
                        Country = "Somewhere",
                        PostalCode = "4321"
                    }
                }

            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < expected.AddressList.Count; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
