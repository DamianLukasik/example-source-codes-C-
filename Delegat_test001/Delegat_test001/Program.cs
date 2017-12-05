using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_test001
{
    class Program
    {      
        static void Main(string[] args)
        {
            SomeLongRunningData sm = new SomeLongRunningData();
            sm.SomeMethod(CallBackMethod);
            //delegat odpowiada za zwrotki (callbacki) - zwrot danych
            //kawałki programu, które odpowiadają 
            //za zwrtoki z innych metod innych klas
            Console.WriteLine("\n");
            Console.ReadKey();

            SomeSolveRunningData sv = new SomeSolveRunningData();
            sv.SolveMethod(CallBackMethod,2,6,2);

            SomeHideData sp = new SomeHideData();
            sp.Show(CallBackMethod);

            Console.ReadKey();
        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }

        static void CallBackMethod(float i)
        {
            Console.WriteLine(i);
        }

        static void CallBackMethod(string s)
        {
            Console.WriteLine(s.Substring(0,2)+" Rrry "+s.Substring(3));
        }
    }

    class SomeLongRunningData
    {
        public delegate void CallBack(int i);

        public void SomeMethod(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {                
                obj(i);
                //Robi się coś w tle
            }
        }
    }

    class SomeSolveRunningData
    {
        public delegate void CallBack(float a);

        public void SolveMethod(CallBack obj, int a, int b, int c)
        {
            float result = (b * b) - 4 * a * c;
            obj(result);
        }
    }

    class SomeHideData
    {
        public delegate void Szpieg(string a);

        private string secret = "tajne dane";
        private string data   = "ukryte dane";

        public void Show(Szpieg obj)
        {
            obj(data);
        }
    }
}

