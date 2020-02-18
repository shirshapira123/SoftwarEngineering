using System;

namespace everylessons
{
    class Program
    {
        public static int Fact(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(num));
            Console.ReadKey();
        }
    }
}
//זכויות יוצרים למגניבים המדליקים
