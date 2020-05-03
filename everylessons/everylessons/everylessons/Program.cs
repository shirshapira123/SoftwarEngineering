using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] shows = new int[16];
            int show = 1, tikets, max = 0;
            while (show != 0)
            {
                Console.WriteLine("enter show number");
                show = int.Parse(Console.ReadLine());
                Console.WriteLine("enter number of tickets");
                tikets = int.Parse(Console.ReadLine());
                shows[show] += tikets;
            }
            for (int i = 1; i < shows.Length; i++)
                Console.WriteLine("show: {0}, tikets: {1}", i, shows[i]);
            for (int i = 0; i < shows.Length; i++)
            {
                if (shows[i] > max)
                    max = i;
            }
            Console.WriteLine(max);



        }
    }
}
//זכויות יוצרים למגניבים המדליקים   