using System;

namespace everylessons
{
    class Program
    { 
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[57];
            for (int i = 0; i<57; i++)
            {
                numbers[i] = random.Next(100, 1000);
            }
            for(int i = 0; i < 57; i++)
            {
                if ((numbers[i]/100) / (numbers[i]%3) == 2)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadKey();
        }
    }
}

                //זכויות יוצרים למגניבים המדליקים
