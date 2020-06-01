using System;

namespace everylessons
{
    class Program
    {
        public static string Cipher(string str, int num)
        {
            int Letter;
            string cipher="";
            for (int i = 0; i < str.Length; i++)
            {
                Letter = (int)str[i];
                if (Letter >= 97 || Letter <= 122)
                {
                    Letter = (Letter * num) % 26 +97;
                    cipher += ((char)Letter).ToString();
                }
                else if (Letter >= 65 || Letter <= 90)
                { 
                    Letter = (Letter * num) % 26 + 65;
                    cipher += ((char)Letter).ToString();
                }
            }
            return cipher;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Cipher(str, num));
                Console.ReadKey();
            }
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   