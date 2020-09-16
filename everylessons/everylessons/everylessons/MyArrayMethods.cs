using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    public static class MyArrayMethods
    {
        public static void One(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = 0;
        }
        public static void Two(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }
        public static void Three(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void Four(int[] arr)
        {
            for (int i = arr.Length-1; i >= 0; i--)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void Five(int[] arr)
        {
            Console.Write("search num: ");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (search == arr[i])
                {
                    Console.WriteLine("the num placed in: ");
                    Console.WriteLine(i+1);
                }
            }
        }
        public static void Six(int[] arr)
        {
            int counter = 0;
            Console.Write("search num: ");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (search == arr[i])
                    counter++;
            }
            Console.WriteLine("the number is placed " + counter + " times");
        }
        public static void Seven(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
                counter += arr[i];
            Console.WriteLine(counter);
        }
        public static void Eight(int[] arr)
        {
            int swich = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = swich;
        }
        public static void Nine(int[] arr)
        {
            int lastNum = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastNum;
        }
        public static void Ten(int[] arr)
        {
            int firstNum = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = firstNum;
        }
        public static void Eleven(int[] arr)
        {
            bool sort = true;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if(arr[i] > arr[i + 1])
                {
                    sort = false;
                }
            }
            Console.WriteLine(sort);
        }
        public static void Twelve(int[] arr)
        {
            int t;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        t = arr[i];
                        arr[i] = arr[k];
                        arr[k] = t;
                    }
                }
            }
        }
        public static int[] Thirteen(int[] arr1, int[] arr2)
        {
            int[] new_arr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                new_arr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                new_arr[i + arr1.Length] = arr2[i];
            }
            MyArrayMethods.Twelve(new_arr);
            return new_arr;
        }
    }
}
