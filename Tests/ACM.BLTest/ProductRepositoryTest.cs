using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "iPhone X",
                ProductDescription = "256G Rose Gold",
                CurrentPrice = 900
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
