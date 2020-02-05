using System;

namespace everylessons
{
    class Program
    {
        private static void Check(int [] choise)
        {
            int max = 0;
            int worker = 0;
            for (int i = 0; i < choise.Length; i++)
            {
                if (max < choise[i])
                {
                    max = choise[i];
                    worker = i;
                }
            }
            Console.WriteLine("worker number "+worker+" got "+max+" votes.");
        }
        static void Main(string[] args)
        {
            Console.Write("how many people are candidates? ");
            int cand = int.Parse(Console.ReadLine());
            int[] choise = new int[cand];
            int workerNum = 0;
            while (workerNum != -999)
            {
                Console.Write("what is your worker number? ");
                workerNum = int.Parse(Console.ReadLine());
                for (int i = 0; i < cand; i++)
                {
                    Console.Write(i +", one for good zero for bad: ");
                    choise[i] += int.Parse(Console.ReadLine());
                }
            }
            Check(choise);
            Console.ReadKey();
        }
    }
}
//זכויות יוצרים למגניבים המדליקים
