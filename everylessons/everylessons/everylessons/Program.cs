using System;

namespace everylessons
{
    class Program
    {
        public static int DividedByThree(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] change = new int[4];
            for (int i = 0; i < change.Length; i++)
            {
                change[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < change.Length; i++)
            {
                change [i] = DividedByThree(change[i]);
            }
            for (int i = 0; i < change.Length; i++)
                Console.WriteLine(change[i]);
            Console.ReadKey();
        }
    }
}

                //זכויות יוצרים למגניבים המדליקים
