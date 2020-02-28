using System;

namespace everylessons
{
    class Program
    {
        static void B(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    Console.Write(num[i, k] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < num.GetLength(1); i++)
            {
                for (int k = 0; k < num.GetLength(0); k++)
                {
                    sum += num[k, i];
                }
                Console.WriteLine("line "+(i+1)+": "+sum);
                sum = 0;
            }
        }
        static void C(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    if (k == 0 || i == 0 || i == num.GetLength(0)-1 || k == num.GetLength(1)-1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(num[i, k] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(num[i, k] + " ");

                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < num.GetLength(1); i++)
            {
                for (int k = 0; k < num.GetLength(0); k++)
                {
                    if (k == 0 || i == 0 || i == num.GetLength(0)-1 || k == num.GetLength(1)-1)
                    {
                        sum += num[k, i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static void D(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    if (k == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(num[i, k] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(num[i, k] + " ");

                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < num.GetLength(1); i++)
            {
                for (int k = 0; k < num.GetLength(0); k++)
                {
                    if (k == i)
                    {
                        sum += num[k, i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static void E(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    if (i < k)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(num[i, k] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(num[i, k] + " ");

                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < num.GetLength(1); i++)
            {
                for (int k = 0; k < num.GetLength(0); k++)
                {
                    if (i < k)
                    {
                        sum += num[k, i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static void F(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    if (i > k)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(num[i, k] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(num[i, k] + " ");

                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < num.GetLength(1); i++)
            {
                for (int k = 0; k < num.GetLength(0); k++)
                {
                    if (i > k)
                    {
                        sum += num[k, i];
                    }
                }
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] num = new int[5, 5];
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    num[i, k] = rnd.Next(1, 10);
                }
            }
            B(num);
            C(num);
            D(num);
            E(num);
            F(num);
            Console.ReadKey();
        }
    }
}
//זכויות יוצרים למגניבים המדליקים   