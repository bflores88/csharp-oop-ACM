using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(3)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 12, 31, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(3);

            //-- Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
