using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            if (addressId == 1)
            {
                return new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Meow meow",
                    StreetLine2 = "Woof woof",
                    City = "Somewhere",
                    State = "Out there",
                    Country = "Neverland",
                    PostalCode = "1234"
                };
            }
            return new Address();
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Temp code for testing
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Meow meow",
                StreetLine2 = "Woof woof",
                City = "Somewhere",
                State = "Out there",
                Country = "Neverland",
                PostalCode = "1234"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "Bork bork",
                StreetLine2 = "Maw maw",
                City = "Over",
                State = "There",
                Country = "Somewhere",
                PostalCode = "4321"
            };
            addressList.Add(address);

            if (customerId == 1)
                return addressList;

            return new List<Address>();

        }

        public bool Save()
        {
            // Code that saves passed in address
            return true;
        }
    }
}
