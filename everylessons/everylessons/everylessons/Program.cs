using System;

namespace everylessons
{
    class Program
    { 
        private static void Arr(int[] grades, int[] sort)
        {
            for(int i=0; i<grades.Length; i++)
            {
                for (int k = 0; k < sort.Length; k++)
                {
                    if (grades[i] == k)
                    {
                        sort[k]++;
                    }
                }
            }
            
        }
        private static void Avg(int[] sort)
        {
            int sum = 0;
            int max_range = 0;
            int max_range_start = 0;
            for (int k = 0; k < 10; k++)
            {
                int range_start = k * 10;
                for (int i = 0; i < 10; i++) 
                {
                    sum += sort[range_start + i];
                }
                if (sum > max_range)
                {
                    max_range = sum;
                    max_range_start = range_start;
                }
                sum = 0;

            }
            Console.WriteLine(max_range+", "+max_range_start+"-"+(max_range_start+9));
        }
        private static void Print(int [] grades)
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(grades[i] + " get " + i);
            }
        }
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
                grades[i] = int.Parse(Console.ReadLine());
            int[] sort = new int[101];
            Arr(grades, sort);
            Print(sort);
            Avg(sort);
            Console.ReadKey();
        }
    }
}

                //זכויות יוצרים למגניבים המדליקים
