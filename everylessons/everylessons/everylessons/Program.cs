using System;

namespace everylessons
{
    class Program
    {
        public static bool BinarySearch(int[] arr, int num)
        {
            int half = arr.Length;
            int low1 = 0, high1 = half / 2 - 1, low2 = high1, high2=arr.Length-1, middle1 = -1, middle2 = -1;
            while (low1 <= high1)
            {
                middle1 = (low1 + high1) / 2;
                if (num == arr[middle1])
                    low1 = high1 + 1;
                else if (num < arr[middle1])
                    high1 = middle1 - 1;
                else
                    low1 = middle1 + 1;
            }
            while (low2 <= high2)
            {
                middle2 = (low2 + high2) / 2;
                if (num == arr[middle2])
                    low2 = high2 + 1;
                else if (num < arr[middle2])
                    high2 = middle2 - 1;
                else
                    low2 = middle2 + 1;
            }
            if (middle1 != 14 && middle2 != 14)
                return true;
            return false;
            
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int[] vs = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 5, 4, 3, 2, 1 };
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(BinarySearch(vs, num));
            }
            //Console.ReadKey();
        }
    }
}
//זכויות יוצרים למגניבים המדליקים
