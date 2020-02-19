using System;

namespace everylessons
{
    class Program
    {
        public static void Sort(int[] grades)
        {
            int t;
            for (int i = 0; i < grades.Length; i++)
            {
                for (int k = i+1; k < grades.Length; k++)
                {
                    if (grades[i] > grades[k])
                    {
                        t = grades[i];
                        grades[i] = grades[k];
                        grades[k] = t;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] grades = new int[200];
            Random rnd = new Random();
            for (int i = 0; i < grades.Length; i++)
                grades[i] = rnd.Next(0,100);
            Sort(grades);

        }
    }
}
//זכויות יוצרים למגניבים המדליקים
