using System;

namespace everylessons
{
    class Program
    {
        public static int CheckBull(int[] randoms, int[] guesses)
        {
            int bulls = 0;
            for (int i=0; i<4; i++)
            {
                if (randoms[i] == guesses[i])
                {
                    bulls++;
                }
            }
            return bulls;
        }
        public static int CheckHit(int[] randoms, int[] guesses)
        {
            int hits = 0;
            for (int i=0; i<4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (randoms[i] == guesses[j] && randoms[i] != guesses[i]) 
                    {
                        hits++;
                    }
                }
            }
            return hits;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int bulls=0;
            int random = rnd.Next(1000, 10000);
            int random_to_print = random;
            int[] randoms = new int[4];
            for (int i = 0; i < 4; i++)
            {
                randoms[i] = random % 10;
                random /= 10;
            }
            while (bulls<4)
            {
                int[] guesses = new int[4];
                int guess = int.Parse(Console.ReadLine());   
                for (int i = 0; i < 4; i++)
                {
                    guesses[i] = guess % 10;
                    guess /= 10;
                }
                int hits = CheckHit(randoms, guesses);
                bulls = CheckBull(randoms, guesses);
                Console.WriteLine("bulls:      hits:");
                Console.WriteLine(" {0}         {1} ",bulls,hits);
            }
            Console.WriteLine("You Won!!");
            Console.ReadKey();
        }
    }
}
