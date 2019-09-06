using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metanit_conditions_exs1
{
    class Program
    {
        //Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).
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
                    Ex5();
                    break;

                case 6:
                    Ex6();
                    break;

                case 7:
                    Ex7();
                    break;
            }

            Console.ReadKey();
        }


            public static void Ex1()//////////////////////////////////////////////////////////
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine("А > B");
                }

                if (a < b)
                {
                    Console.WriteLine("А < B");
                }

                if (a == b)
                {
                    Console.WriteLine("А = B");
                }
            }


            public static void Ex2()//////////////////////////////////////////////////////////
            {
                int a = Convert.ToInt32(Console.ReadLine());
            

                if ((a >= 5) && (a <= 10))            
                    Console.WriteLine("норм");            
                else
                    Console.WriteLine("не норм");

           
            }


            public static void Ex3()//////////////////////////////////////////////////////////
            {
                int a = Convert.ToInt32(Console.ReadLine());


                if ((a == 5) || (a == 10))
                    Console.WriteLine("норм");
                else
                    Console.WriteLine("не норм");
            }


            public static void Ex4()//////////////////////////////////////////////////////////
            {
                double sum = Convert.ToDouble(Console.ReadLine());

                if (sum < 100)
                    sum *= 1.05;
                else if (sum < 200)
                    sum *= 1.07;
                else
                    sum *= 1.1;

                Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
            }


            public static void Ex5()//////////////////////////////////////////////////////////
            {
                double sum = Convert.ToDouble(Console.ReadLine());

                if (sum < 100)
                    sum *= 1.05;
                else if (sum < 200)
                    sum *= 1.07;
                else
                    sum *= 1.1;

            sum += 15;

                Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
            }


            public static void Ex6()//////////////////////////////////////////////////////////
            {
                int OpName = Convert.ToInt32(Console.ReadLine());

            switch (OpName)
            {
                case 1: 
                Console.WriteLine($"сложение");
                break;

                case 2:
                Console.WriteLine($"вычитание");
                break;

                default:
                Console.WriteLine($"NA");
                break;
            }

            }


            public static void Ex7()//////////////////////////////////////////////////////////
            {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int OpName = Convert.ToInt32(Console.ReadLine());
            switch (OpName)
                {
                    case 1:
                        a += b;
                        Console.WriteLine($"сложение: {a}");
                        break;

                    case 2:
                        a -= b;
                        Console.WriteLine($"вычитание: {a}");
                        break;

                    default:
                        Console.WriteLine($"NA");
                        break;
                }

            }
    }
}
