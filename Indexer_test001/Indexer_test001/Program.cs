using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_test001
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customers = new Customer();
            Customers.GetAddress("Warszawa");
            Customers.GetAddress(123456);

            //używanie indekserów
            var a = Customers["Warszawa"];
            var b = Customers[123456];

            //Lista<String> a;
            //a[]
        }
    }
}
