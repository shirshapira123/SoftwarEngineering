using System;

namespace everylessons
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] counter = new int[11];
            int i, num;
            for (i = 0; i < counter.Length; i++)
            {
                counter[i] = 0; 
            }
            for (i = 0; i <= 1000; i++)
            {
                Console.WriteLine("enter a number");
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 10)
                    counter[num]++;
            }
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ", " + counter[i]);
            }
        }
    }
}
//זכויות יוצרים למגניבים המדליקים   