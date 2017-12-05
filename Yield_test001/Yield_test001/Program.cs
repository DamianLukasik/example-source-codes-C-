using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_test001
{
    class Program
    {
        static List<int> myList = new List<int>();

        static void Main(string[] args)
        {
            FillList();
            foreach (var item in Total())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void FillList()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
        }

        //Custom iteration
        static IEnumerable<int> Filter()
        {
            //List<int> tmp = new List<int>();
            foreach (var item in myList)
            {
                if (item > 3)
                {
                    //tmp.Add(item);
                    yield return item;
                    //wykonuje operacje na oryginalnej liście
                    //zapamiętuje indeks i wraca 
                }
            }
            //return tmp;
        }

        //Statefor iteration
        static IEnumerable<int> Total()
        {
            int totalNumber = 0;
            foreach (var item in myList)
            {
                totalNumber += item;
                //przechowuje stan w danej liście
                yield return (totalNumber);
                //zachowuje stan poprzedniej pętli
            }
        }
    }
}
