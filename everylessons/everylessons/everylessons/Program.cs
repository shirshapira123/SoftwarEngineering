using System;

namespace everylessons
{
    class Program
    {
        public static void Merge(int[] firstArr, int [] secondArr)
        {
            int p1 = 0, p2 = 0, p3 = 0;
            int[] mergeArr = new int[firstArr.Length + secondArr.Length];
            while (p1 < firstArr.Length && p2 < secondArr.Length)
            {
                if (firstArr[p1] < secondArr[p2])
                {
                    mergeArr[p3] = firstArr[p1];
                    p1++;
                }
                else if (secondArr[p2] < firstArr[p1])
                {
                    mergeArr[p3] = secondArr[p2];
                    p2++;
                }
                else
                {
                    mergeArr[p3] = firstArr[p1];
                    p3++;
                    mergeArr[p3] = secondArr[p2];
                    p2++;
                    p1++;
                }
                p3++;
            }
            while (p1 < firstArr.Length) 
            {
                mergeArr[p3] = firstArr[p1];
                p1++;
                p3++;
            }
            while (p2 < secondArr.Length) 
            {
                mergeArr[p3] = secondArr[p2];
                p2++;
                p3++;
            }
            for (int i = 0; i < mergeArr.Length; i++)
            {
                Console.Write(mergeArr[i] + ", ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[6] { 3, 6, 7, 9, 12, 56 };
            int[] arr2 = new int[7] { 6, 8, 20, 50, 98, 121, 256 };
            Merge(arr1, arr2);
            
            Console.ReadKey();
        }
    }
}
//זכויות יוצרים למגניבים המדליקים
