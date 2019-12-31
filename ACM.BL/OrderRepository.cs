using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            // Code to get defined order
            if (orderId == 3)
            {
                return new Order(3)
                {
                    OrderDate = new DateTimeOffset(DateTime.Now.Year, 12, 31, 10, 00, 00, new TimeSpan(7, 0, 0))
                };
            }
            return new Order();
        }

        public bool Save()
        {
            // Code that saves the defined order
            return true;
        }
    }
}
