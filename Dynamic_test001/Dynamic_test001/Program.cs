using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_test001
{
    class Program
    {
        static ExampleClass cls = new ExampleClass();
        static dynamic dls;

        static void Main(string[] args)
        {
            //string tojeststring = "aa";
            //tojeststring.ToUpper(); //  AA

            //object tojestobject = "aa";
            //tojestobject.ToUpper(); //nie ma metody w klasie object

            //dynamic tojestDynamic = "aa";//
            //tojestDynamic.ToUpper();//sprawdza czy może coś zrobić 



            //int myInt = 1 + 3;
            //var mvar = 1 + 3;
            //dynamic dyn = 1 + 3;
            //object obj = 1 + 3;

            //Console.WriteLine(myInt.GetType());
            //Console.WriteLine(mvar.GetType());
            //Console.WriteLine(dyn.GetType());
            //Console.WriteLine(obj.GetType());



            dynamic dyna;//nie wie co chcemy przypisać
            int a = 20;

            dyna = a;//przypisana wartość i typ
           
            string b = "to jest Dynamic !!";

            dyna = b;//zmienia typ zmiennej (niemożliwe w var)
         
            DateTime dt = DateTime.Now;

            dyna = dt;//zmiena typ i staje się DateTime

            Console.ReadKey();


            cls.ExampleMethod("cls");
            dls = new ExampleClass();
            dls.ExampleMethod("dls");
            dls.ExampleMethod();//wyrzuci błąd, bo dynamic nie wie, że to jest błąd
        }

        public class ExampleClass
        {
            public void ExampleMethod(string test)
            {
                var a = test;
            }
        }
    }
}
