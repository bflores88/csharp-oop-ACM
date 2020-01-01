using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "bBaggins@hobbit.me",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 10
            };
            changedItems.Add(product);

            //-- Act
            LoggingService.WriteToFile(changedItems);

            //-- Assert
            // Nothing here to assert
        }
    }
}
