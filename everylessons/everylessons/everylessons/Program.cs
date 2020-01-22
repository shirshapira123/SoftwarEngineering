using System;

namespace everylessons
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] flowers = new int[10];
            for (int i = 0; i < flowers.Length; i++)
                flowers[i] = int.Parse(Console.ReadLine());
            int[] flowers2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (flowers[i] / 100 == 2)
                {
                    flowers2[i] = flowers[i];
                    flowers[i] = 0;
                }
            }
            Console.WriteLine(flowers);

            Console.ReadKey();
        }
    }
}

                //Array.Copy(flowers,);
                //זכויות יוצרים למגניבים המדליקים
