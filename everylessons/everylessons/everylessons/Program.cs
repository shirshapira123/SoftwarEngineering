using System;

namespace everylessons
{
    class Program
    {
        //1
        public static void InputArray(int[] arr)
        {
            InputArray(arr, 0);
        }
        private static void InputArray(int[] arr, int index)
        {
            if (index < arr.Length)
            {
                arr[index] = int.Parse(Console.ReadLine());
                InputArray(arr, index + 1);
            }
        }


        //2
        public static void OutputArrayLeftToRight(int[] arr)
        {
            OutputArrayLeftToRight(arr, 0);
        }
        private static void OutputArrayLeftToRight(int[] arr, int index)
        {
            if (index < arr.Length)
            {
                Console.WriteLine(arr[index]);
                OutputArrayLeftToRight(arr, index + 1);
            }
        }


        //3
        public static void OutputArrayRightToLeft(int[] arr)
        {
            OutputArrayRightToLeft(arr, arr.Length-1);
        }
        private static void OutputArrayRightToLeft(int[] arr, int index)
        {
            if (index >= 0)
            {
                Console.WriteLine(arr[index]);
                OutputArrayRightToLeft(arr, index - 1);
            }
        }


        //4
        public static bool IsFound(int[] arr, int number)
        {
            return IsFound(arr, number, 0);
        }
        private static bool IsFound(int[] arr, int number, int index)
        {
            if (arr.Length > index)
            {
                if (arr[index] == number)
                {
                    return true;
                }
                return IsFound(arr, number, index + 1);
            }
            return false;
        }


        //5
        public static int CountExist(int[] arr, int number)
        {
            return CountExist(arr, number, 0);
        }
        private static int CountExist(int[] arr, int number, int index)
        {
            if(arr.Length > index)
            {
                if (number == arr[index])
                {
                    return CountExist(arr, number, index + 1) + 1;
                }
                return CountExist(arr, number, index + 1);
            }
            return 0;
        }


        //6
        public static bool IsUpSeriesArray(int[] arr)
        {
            return IsUpSeriesArray(arr, 0);
        }
        private static bool IsUpSeriesArray(int[] arr, int index)
        {
            if (arr.Length > index + 1)
            {
                if (arr[index] <= arr[index + 1])
                {
                    return IsUpSeriesArray(arr, index + 1);
                }
                return false;
            }
            return true; 
        }


        //7
        public static int SumArray(int[] arr)
        {
            return SumArray(arr, 0);
        }
        private static int SumArray(int[] arr, int index)
        {
            if (arr.Length > index)
            {
                return arr[index] + SumArray(arr, index + 1);
            }
            return 0;
        }


        //8
        public static int MaxArray(int[] arr)
        {
            return MaxArray(arr, 0);
        }
        private static int MaxArray(int[] arr, int index)
        {
            if (arr.Length > index)
            {
                return Math.Max(arr[index], MaxArray(arr, index + 1));
            }
            return 0;
        }


        //9
        public static void FillArray(int[] arr, int number)
        {
            FillArray(arr, number, 0);
        }
        private static void FillArray(int[] arr, int number, int index)
        {
            if (index < arr.Length)
            {
                arr[index] = number + index;
                FillArray(arr, number, index + 1);
            }
        }


        //10
        public static void SeriesArray(int[] arr, int a1, int d)
        {
            SeriesArray(arr, a1, d, 0);
        }
        private static void SeriesArray(int[] arr, int a1, int d, int index)
        {
            if (index < arr.Length)
            {
                arr[index] = a1 + index*d;
                SeriesArray(arr, a1, d, index + 1);
            }
        }


        //11
        public static void FibSeriesArray(int[] arr, int number1, int number2)
        {
            FibSeriesArray(arr, number1, number2, 2);
        }
        private static void FibSeriesArray(int[] arr, int number1, int number2, int index)
        {
            arr[0] = number1;
            arr[1] = number2;
            if (index < arr.Length)
            {
                arr[index] = arr[index - 1] + arr[index - 2];
                FibSeriesArray(arr, number1, number2, index + 1);
            }
        }


        //12
        public static bool IsSeriesArray(int[] arr)
        {
            return IsSeriesArray(arr, 2);
        }
        private static bool IsSeriesArray(int[] arr, int index)
        {
            if (arr.Length > index)
            {
                if (arr[index] == arr[index - 1] + arr[index - 2])
                {
                    return IsSeriesArray(arr, index + 1);
                }
                return false;
            }
            return true;
        }


        //13
        public static bool IsPolindromArray(int[] arr)
        {
            return IsPolindromArray(arr, 4, 9);
        }
        private static bool IsPolindromArray(int[] arr, int start, int last)
        {
            if ((last - start) % 2 == 0)
                return false;

            if (arr[start] == arr[last])
            {
                if (last - start != 1)
                    return true;
                return IsPolindromArray(arr, start + 1, last - 1);
            }
            return false;
        }


        //14
        public static bool BinarySearchArray(int[] arr, int number)
        {
            return BinarySearchArray(arr, number, 3, 6);
        }
        private static bool BinarySearchArray(int[] arr, int number, int first, int last)
        {
            int middle = (first + last) / 2;
            if (arr[middle] == number)
                return true;
            else if (first >= last)
                return false;
            else if (number < arr[middle])
                return BinarySearchArray(arr, number, first, middle);
            else
                return BinarySearchArray(arr, number, middle, last);
        }


        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10] {1, 2, 3, 4, 1, 2, 3, 3, 2, 1};
            InputArray(a);
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            OutputArrayLeftToRight(a);
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            OutputArrayRightToLeft(a);
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(IsFound(a, 11));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(CountExist(a, 1));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(IsUpSeriesArray(a));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(SumArray(a));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(MaxArray(a));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            FillArray(a, 4);
            OutputArrayLeftToRight(a);
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            SeriesArray(a, 9, 3);
            OutputArrayLeftToRight(a);
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            FibSeriesArray(a, 1, 1);
            OutputArrayLeftToRight(a);
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(IsSeriesArray(a));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(IsPolindromArray(a));
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(IsPolindromArray(b));
            b = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\n\n\n-----------------------------------\n\n\n");
            Console.WriteLine(BinarySearchArray(b, 2));
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   