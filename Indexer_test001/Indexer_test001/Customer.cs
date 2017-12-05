using System.Collections.Generic;

namespace Indexer_test001
{
    public class Customer
    {
        private List<Address> Addresses = new List<Address>();
        public Customer()
        {
            Addresses.Add(new Address { Pin = 123456, Street = "Dojazdowa 3", City = "Częstochowa", Country = "Polska" });
            Addresses.Add(new Address { Pin = 123456, Street = "Tarnowska 8", City = "Częstochowa", Country = "Polska" });
            Addresses.Add(new Address { Pin = 123456, Street = "Górnicza 10", City = "Katowice", Country = "Polska" });
            Addresses.Add(new Address { Pin = 123456, Street = "Orkana 20", City = "Kraków", Country = "Polska" });
            Addresses.Add(new Address { Pin = 123456, Street = "Lechonia 7", City = "Katowice", Country = "Polska" });
            Addresses.Add(new Address { Pin = 123456, Street = "3 maja 15", City = "Warszawa", Country = "Polska" });
            Addresses.Add(new Address { Pin = 123456, Street = "Dąbrowskiego 12", City = "Częstochowa", Country = "Polska" });
        }
        public Address GetAddress(int Pin)
        {
            foreach (Address item in Addresses)
            {
                if (item.Pin == Pin)
                    return item;
            }
            return null;
        }
        public Address GetAddress(string City)
        {
            foreach (Address item in Addresses)
            {
                if (item.City == City)
                    return item;
            }
            return null;
        }

        //Indexery
        public Address this[int Pin]
        {
            get
            {
                foreach (Address item in Addresses)
                {
                    if (item.Pin == Pin)
                        return item;
                }
                return null;
            }
        }

        public Address this[string City]
        {
            get
            {
                foreach (Address item in Addresses)
                {
                    if (item.City == City)
                        return item;
                }
                return null;
            }
        }
    }

    public class Address
    {
        public int Pin { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}