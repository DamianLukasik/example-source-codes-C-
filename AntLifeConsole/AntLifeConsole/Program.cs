using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntLifeLibrary.TestClass;
using AntLifeLibrary.Poli;

namespace AntLifeConsole
{
    enum TestEnum
    {
        Poniedzialek = 10,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    class MaxMin<Anytype>
    {
        public Anytype Compare(Anytype a, Anytype b)
        {
            if (a.Equals(b))
            {
                return a;
            }
            return b;
        }
    }

    class Compare<AnyType>//klasa generyczna
    {
        public bool CompareAnyType(AnyType a, AnyType b)//metoda generyczna
        {
            return a.Equals(b) ? true : false;
        }
    }

    class Program
    {
        TestClass a = new TestClass();
        delegate int PointToAddMethod(int a, int b);//delegat

        static void Main(string[] args)
        {
            //RunKeyValuePair();
            //RunEnum();
            //RunAnthill();

            //Basebody bb = new Basebody();
            //bb.CreateBase("BaseBody - Name", 1.1f, 2.2f);

            //MilitaryBase aaa = new MilitaryBase(10);
            //aaa.CreateBase("MilitaryBase - Name", 9.9f, 10.10f);//100);

            //Basebody mbb = new MilitaryBase();
            //mbb.CreateBase("MilitaryBase - Name", 3.3f, 4.4f);

            //MilitaryBase bbm = new Basebody();//błąd
            /*
            List<int> lista = new List<int>();

            Compare<int> compInt = new Compare<int>();
            Console.WriteLine(compInt.CompareAnyType(2, 2));

            Compare<string> compStr = new Compare<string>();
            Console.WriteLine(compStr.CompareAnyType("aa","aa"));

            MaxMin<float> comp = new MaxMin<float>();
            Console.WriteLine(comp.Compare(2.2f,3.4f));
            */

            PointToAddMethod pointAdd = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(pointAdd.Invoke(6,4).ToString());
            Console.ReadKey();
        }

        private static void RunAnthill()
        {

        }

        private static void RunEnum()
        {
            TestEnum naszeEnum = TestEnum.Sroda;

            switch (naszeEnum)
            {
                case TestEnum.Poniedzialek:
                    break;
                case TestEnum.Wtorek:
                    break;
                case TestEnum.Sroda:
                    Console.WriteLine((int)TestEnum.Sroda);
                    break;
                default:
                    break;
            }

            Console.WriteLine((int)TestEnum.Poniedzialek);
            
        }

        public static void RunKeyValuePair()
        {
            KeyValuePair<int, TestClass> a =
                new KeyValuePair<int, TestClass>
                (1, new TestClass { TestClassId = 1, TestClassName = "test 1" });
            KeyValuePair<int, TestClass> b =
               new KeyValuePair<int, TestClass>
               (1, new TestClass { TestClassId = 1, TestClassName = "test 2" });

            List<KeyValuePair<int, TestClass>> listOfKvp = new List<KeyValuePair<int, TestClass>>();

            listOfKvp.Add(a);
            listOfKvp.Add(b);
        }

        public static void RunDictionary()
        {
            Dictionary<int, TestClass> a = new Dictionary<int, TestClass>();

            a.Add(1, new TestClass { TestClassId = 1, TestClassName = "test 1" });
            a.Add(2, new TestClass { TestClassId = 4, TestClassName = "test 2" });
            a.Add(3, new TestClass { TestClassId = 8, TestClassName = "test 3" });
            a.Add(4, new TestClass { TestClassId = 7, TestClassName = "test 4" });

            foreach (var i in a)
            {
                Console.WriteLine(i.Key + " | " + i.Value.TestClassId + " | " + i.Value.TestClassName);
            }
            TestClass b;

            Console.WriteLine(a.TryGetValue(1, out b));
            Console.WriteLine(b.TestClassName);

            Console.WriteLine(a.ElementAt(1).Value.TestClassName);
                        
            List<TestClass> c = new List<TestClass>();
            
        }

        public static int Dodawanie(int a, int b)
        {
            return a + b;
        }

        public static int Dodawanie(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
