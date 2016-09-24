using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main()
        {
            prog6();
        }
        static void prog1()
        {
            try
            {
                int[] mas = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int P = int.Parse(Console.ReadLine());
                int Q = int.Parse(Console.ReadLine());

                int g = 0;
                if (P < Q)
                    g++;
                Console.WriteLine(g);
            }
            catch { Console.WriteLine("KRITICHESKAYA!"); }
            Console.ReadKey();
        }
        static void prog2()
        {
            int[] mas = new int[8] { 1, -2, -3, 3, 32, 2, -21, 0 };
            int a = 0;
            int f = 0;
            for (int i = 0; i < 8; i++)
                if (mas[i] < 0)
                {
                    a=mas[i];
                    f = i;
                }
            Console.WriteLine("значение =" + a);
            Console.WriteLine("номер элемента = " + f);
            Console.ReadKey();
        }
        static void prog3()
        {
            int[] mas = new int[5] { 2, 3, 4, -2, 12 };
            int a = 0;
            int s = 0;
            while (mas[a] > 0)
            {
                s = s + mas[a]*mas[a];
                a++;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static void prog4()
        {
            int[] mas = new int[10] { 1, 12, 14, 17, 34, 10, 11, 15, 19, 13 };
            int max = mas[0];
            int s = 0;
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    a = i;
                }
            }
            for(int j = 0; j < a; j++)
            {
                s = s + mas[j];
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static void prog5()
        {
            double[] mas = new double[] { 1, 12, 13, 4, 9, 7 };
            double max = mas[0]; double s = 0;
            int a = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    a = i;
                }
                s = s + mas[i];
            }
            double sr = s / mas.Length;
            for (int i = a; i < mas.Length; i++)
            {
                mas[i] = sr;
                Console.Write(mas[i] + "");
            }
            Console.ReadKey();
        }
        static void prog6()
        { 
                int[,] M1 = new int[3, 3] { { 2, 5, 2 }, { 3, 3, 3 }, { 2, 1, 1 } };
                int[] M2 = new int[3];
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        M2[j] = M2[j] + M1[i, j];
                Console.WriteLine("{0} {1} {2}", M2[0], M2[1], M2[2]);
                Console.ReadKey();
        }
    }
}
