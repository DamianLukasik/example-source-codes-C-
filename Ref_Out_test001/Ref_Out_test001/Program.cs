using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out_test001
{
    class Program
    {
        static int outsideInt = 20;

        static void Main(string[] args)
        {
            int outsideInt = 20;
            SomeMethod(out outsideInt);

            //out i ref - są słowami kluczowymi pomagającymi przekazać referencje
            //ref - przekazujemy referencje i wartość (działa dwustronie)
            //out - przekazujemy referencje (działą jednostronie)

            Console.WriteLine(outsideInt);
            Console.ReadLine();
        }

        private static void SomeMethod(out int insideInt)
        {
            insideInt = 0;
            insideInt = insideInt + 10;
        }
    }
}
