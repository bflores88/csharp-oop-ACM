using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create instance of the Product class
            Product product = new Product(productId);

            // Pass in requested Id

            // Code that retrieves the defined product

            // Temp code for testing
            if (productId == 2)
            {
                product.ProductName = "iPhone X";
                product.ProductDescription = "256G Rose Gold";
                product.CurrentPrice = 900;

            }

            Object myObject = new Object();
            Console.WriteLine(($"Object: {myObject.ToString()}"));
            Console.WriteLine(($"Product: {product.ToString()}"));

            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
