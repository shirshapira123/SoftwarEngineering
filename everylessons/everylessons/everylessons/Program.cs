using System;

namespace everylessons
{
    class Program
    {
        public static void isometric(char[] arr, int length)
        {
            int[] arrey = new int[26];
            int last = 0;

            for (int i = 0; i < length; i++)
            {
                int chr = (int)arr[i];

                if (chr >= 97 && chr <= 123)
                {
                    arrey[chr - 97]++;
                    last = arrey[chr - 97];
                }
                else if (chr >= 65 && chr <= 91)
                {
                    arrey[chr - 65]++;
                    last = arrey[chr - 65];
                }
            }

            bool isOK = true;

            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] > 0 && arrey[i] != last)
                {
                    isOK = false;
                    break;
                }
            }

            if (isOK)
                Console.WriteLine("Isogram");
            else
                Console.WriteLine("Not Isogram");
        }
        public static char[] Kelet()
        {
            Console.WriteLine("Input the word's length");
            int length = int.Parse(Console.ReadLine());
            char[] arr = new char[length];
            Console.WriteLine("Enter word letter by letter");
            for (int b = 0; b < length; b++)
            {
                char a = Char.Parse(Console.ReadLine());
                arr[b] = a;
            }
            return arr;
        }
        public static void ispanagram(char[] arr, int length)          {
            int[] arrey = new int[26];
            int last = 0;

            for (int i = 0; i < length; i++)
            {
                int chr = (int)arr[i];

                if (chr >= 97 && chr <= 123)
                {
                    arrey[chr - 97]++;
                    last = arrey[chr - 97];
                }
                else if (chr >= 65 && chr <= 91)
                {
                    arrey[chr - 65]++;
                    last = arrey[chr - 65];
                }
            }

            bool isOK = true;
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] == 0 || arrey[i] != last)
                {
                    isOK = false;
                    break;
                }
            }
            bool isPan = true;

            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] == 0)
                {
                    isPan = false;
                    break;
                }
            }
            if (isPan)
                Console.WriteLine("A panagram");
            if (isOK && last == 1)
                Console.WriteLine("This is a perfect Panagram");
            if (!isPan)
                Console.WriteLine("Not a Panagram");
        }
        static void Main(string[] args)
        {
            char[] arr = Kelet();
            isometric(arr, arr.Length);
            ispanagram(arr, arr.Length);
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   