using System;

namespace everylessons
{
    class Program
    { 
        static void Main(string[] args)
        {
            const int N = 31;
            int[] a = new int[N];
            int i, j, workers, min = 1, max = 0, imax = 0, jmax = 0;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
            for (i = 1; i < N; i++)
            {
                Console.WriteLine("floor " + i);
                for (j = 1; j <= 7; j++)
                {
                    Console.WriteLine("enter the amount of people in office number " + j);
                    workers = int.Parse(Console.ReadLine());
                    a[i] += workers;
                    if (workers > max)
                    {
                        max = workers;
                        imax = i;
                        jmax = j;
                    }
                }
            }
            for (i = 1; i < N; i++)
            {
                Console.WriteLine("floor " + i + "," +a[i]);
            }
            for (i = 1; i < N; i++)
            {
                if (a[i] < a[min])
                    min = i;
            }
            Console.WriteLine("the floor that have the smallest amount of workers is " + min + "the number of workers in this floor is " + a[min]);
            Console.WriteLine ("the office that has the biggest amount of workers is office " + jmax + " on floor " + imax + " the number of workers in this office is " + max);                      
        }
    }
}
//זכויות יוצרים למגניבים המדליקים   