using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metanit_cycles_exs
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExNum = Convert.ToInt32(Console.ReadLine());

            switch (ExNum)
            {
                case 1:
                    Ex1();
                    break;

                case 2:
                    Ex2();
                    break;

                case 3:
                    Ex3();
                    break;

                case 4:
                    Ex4();
                    break;

                case 5:
                    Ex1arr();
                    break;
            }

            Console.ReadKey();
        }


        public static void Ex1()//////////////////////////////////////////////////////////
        {
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                sum *= 1.07M;
            }

            Console.WriteLine($"{sum}");
        }


        public static void Ex2()//////////////////////////////////////////////////////////
        {
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i < num)
            {
                i++;
                sum *= 1.07M;
            }

            Console.WriteLine($"{sum}");
        }


        public static void Ex3()//////////////////////////////////////////////////////////
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                    Console.Write($"{i * j}\t");

                Console.WriteLine();
            }

         }


        public static void Ex4()//////////////////////////////////////////////////////////
        {
            int a = 0;
            int b = 0;
            while (true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                if ((a < 0) || (a > 10) || (b < 0) || (b > 10))
                {
                    Console.WriteLine("Неверный ввод");
                }
                else
                    break;
            }

            a *= b;
            Console.WriteLine(a);
        }


        public static void Ex1arr()//////////////////////////////////////////////////////////
        {
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            int[] abc = new int[3];

            for (int i = 0; i < abc.Length; i++)
            {
                abc[i] = mas.GetUpperBound(i);
            }
            foreach (int i in abc)
            {
                Console.Write(i);
            }

            Console.Write("{");
            for (int i = 0; i <= abc[0]; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= abc[1]; j++)
                {

                    Console.Write("{");
                    for (int k = 0; k <= abc[2]; k++)
                    {

                        Console.Write($"{mas[i, j, k]}");
                        if (!(k == abc[2]))
                        {
                            Console.Write(" , ");
                        }
                    }
                            Console.Write("}");

                    if (!(j == abc[1]))
                    {
                        Console.Write(" , ");
                    }
                }
                Console.Write("}");
                if (!(i == abc[0]))
                {
                    Console.Write(" , ");
                }
            }
            Console.Write("}");
        }




    }
}

