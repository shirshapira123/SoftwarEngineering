using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyArrayMethods.Three(arr);
            MyArrayMethods.One(arr);
            MyArrayMethods.Three(arr);
            MyArrayMethods.Two(arr);
            MyArrayMethods.Four(arr);
            MyArrayMethods.Nine(arr);
            MyArrayMethods.Three(arr);
            MyArrayMethods.Ten(arr);
            MyArrayMethods.Three(arr);
            MyArrayMethods.Eleven(arr);
            MyArrayMethods.Five(arr);
            MyArrayMethods.Six(arr);
            MyArrayMethods.Seven(arr);
            MyArrayMethods.Eight(arr);
            MyArrayMethods.Twelve(arr);
            MyArrayMethods.Eleven(arr);
            MyArrayMethods.Three(arr);
            int[] arr2 = new int[5];
            MyArrayMethods.Two(arr2);
            int[] new_arr = MyArrayMethods.Thirteen(arr, arr2);
            MyArrayMethods.Three(new_arr);
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   