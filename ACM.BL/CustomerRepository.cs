using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();

        }
        private AddressRepository addressRepository { get; set; }

        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer

            // For testing purposes
            if (customerId == 1)
            {
                return new Customer(1)
                {
                    FirstName = "Bilbo",
                    LastName = "Baggins",
                    EmailAddress = "bBaggins@hobbit.me",
                    AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList()
                };
            }

            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            // Code that retrieves all customers
            return new List<Customer>();
        }

        // Saves the current customer
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
