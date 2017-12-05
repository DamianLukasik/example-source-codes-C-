using System;

namespace Tablica_test001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[,] a = new int[10, 10];
            double[] b = new double[2];
            string[,,] c = new string[12, 7, 24];//tablica wielowymiarowa

            b[0] = 3.14;
            b[1] = 2.19;
            a[2,0] = 10;
            c[2, 3, 7] = "str";//dostęp

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("b[" + i + "]=" + b[i]);//wyświetlenie wszystkich elementów tablicy
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("a[" + i + ","+j+"]=" + a[i,j]+"\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            Console.Write("\n\n");
            int[][] d = new int[10][]; //tablica wyszczerbiona

            d[0] = new int[3];
            d[1] = new int[2];
            d[2] = new int[7];
            d[3] = new int[5];
            d[4] = new int[6];
            d[5] = new int[6];
            d[6] = new int[11];
            d[7] = new int[4];
            d[8] = new int[1];
            d[9] = new int[8];

            d[0][2] = 1;

            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    Console.Write("d[" + i + "," + j + "]=" + d[i][j] + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
