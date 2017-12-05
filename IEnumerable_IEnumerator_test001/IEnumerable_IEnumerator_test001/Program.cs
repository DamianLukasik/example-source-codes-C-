using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_test001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(100);
            myList.Add(200);
            myList.Add(300);
            myList.Add(400);
            myList.Add(500);
            myList.Add(600);
            myList.Add(1002);
            myList.Add(1003);
            myList.Add(1004);
            myList.Add(1005);

            IEnumerable<int> ienumerable = myList.AsEnumerable();
            LoopTo1000(ienumerable);
            //foreach (var item in ienumerable)//nie wie w jakim jest stanie
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("\n\n");

            IEnumerator<int> ienumerator = myList.GetEnumerator();
            LoopTo1000(ienumerator);
            //while (ienumerator.MoveNext())//wie w jakim jest stanie
            //{
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}



            Console.ReadKey();
        }

        static void LoopTo1000(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
                if (e.Current > 999)
                {
                    LoopAbove1000(e);
                }
            }
        }

        static void LoopAbove1000(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
            }
        }

        static void LoopTo1000(IEnumerable<int> e)
        {
            foreach (var item in e)
            {
                Console.WriteLine(item.ToString());
                if (item > 999)
                {
                    LoopAbove1000(e);
                }
            }
        }

        static void LoopAbove1000(IEnumerable<int> e)
        {
            foreach (var item in e)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
