using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action_Predicate_test001
{
    class Program
    {


        static void Main(string[] args)
        {
            //Func - delegat który coś wprowadza i coś zwraca
            Func<Double, Double> cpointer = r => Math.PI * r * r;
            double area = cpointer(20);

            //Action - delegat który nic nie zwraca
            Action<string> MyAction = s => Console.WriteLine(s);
            MyAction("To ja");

            //Predicate - delegat który zwraca prawdę lub fałsz
            Predicate<string> CheckIfStringIsGreatherThan5 = g => g.Length > 5;
            Console.WriteLine(CheckIfStringIsGreatherThan5("Ala ma kota"));

            Console.ReadKey();
        }        
    }
}
