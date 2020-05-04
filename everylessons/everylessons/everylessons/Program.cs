using System;

namespace everylessons
{
    class Program
    {
        static void ExerciseOne(int [,] cinema)
        {
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int k = 0; k < cinema.GetLength(1); k++)
                {
                    cinema[i, k] = 0;
                }
            }
        }
        static bool ExerciseTwo(int chair, int row, int[,] cinema)
        {
            if (cinema[row, chair] == 0)
            {
                return true;
            }
            return false;
        }
        static void ExerciseThree(int chair, int row, int[,] cinema)
        {
            if (ExerciseTwo(chair,row, cinema))
            {
                cinema[row, chair] = 1;
                Console.WriteLine("verified shopping");
            }
            else
                Console.WriteLine("this place isn't available.");
        }
        static void ExerciseFour(int[,] cinema)
        {
            int available = 0;
            int all_available = 0;
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int k = 0; k < cinema.GetLength(1); k++)
                {
                    if (cinema[i, k] == 0)
                    {
                        available++;
                        all_available++;
                    }
                }
                Console.WriteLine("there are " +available+ " available places in line " +(i+1));
                available = 0;
            }
            Console.WriteLine("there are " + all_available + " available places in all lines");
        }
        static void ExerciseFive(int[,] cinema)
        {
            int not_available = 0;
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int k = 0; k < cinema.GetLength(1); k++)
                {
                    if(cinema[i, k] == 1)
                    not_available++;
                }
            }
            Console.WriteLine("there are " + not_available + " places which bought in all lines");
        }

        static void Main(string[] args)
        {
            int[,] cinema = new int[10,14];
            ExerciseOne(cinema);
            for (int i = 0; i < 100; i++)
            {
                Console.Write("row: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("chair: ");
                int chair = int.Parse(Console.ReadLine());
                ExerciseThree(chair-1, row-1, cinema);
            }
            ExerciseFour(cinema);
            ExerciseFive(cinema);
            Console.ReadKey();

        }
    }
}
    //זכויות יוצרים למגניבים המדליקים   
