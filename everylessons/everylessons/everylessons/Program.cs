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
            int random = rnd.Next(1000, 10000);
            int[] randoms = new int[4];
            int[] guesses = new int[4];
            int guess = int.Parse(Console.ReadLine());
            for (int i=0; i<4; i++)
            {
                randoms[i] = random % 10;
                random /= 10;
            }
            for (int i=0; i<4; i++)
            {
                guesses[i] = guess % 10;
                guess /= 10;
            }
            int hits = CheckHit(randoms, guesses);
            int bull = CheckBull(randoms, guesses);
            
            Console.ReadKey();
        }
    }
}
