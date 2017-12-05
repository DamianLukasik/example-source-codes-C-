using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_test001
{
    class Program
    {
        static void Main(string[] args)
        {
            object a1 = "Jaka jest różnica między Equals i ==";
            object a2 = new string("Jaka jest różnica między Equals i ==".ToCharArray());

            string b = "sss";//wyjątek
            string c = "sss";

            Console.WriteLine(b == c);//porównuje wartości - string
            Console.WriteLine(b.Equals(c));//porównuje wartości
            Console.WriteLine("------------------------");

            Console.WriteLine(a1 == a2);//porównuje referencje objektów
            Console.WriteLine(a1.Equals(a2));//porównuje wartości
            Console.ReadKey();

        }
    }
}
