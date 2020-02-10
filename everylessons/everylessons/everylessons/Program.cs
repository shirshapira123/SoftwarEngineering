using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many chars? ");
            int vsLength = int.Parse(Console.ReadLine());
            char[] vs = new char[vsLength];
            for (int i = 0; i < vs.Length; i++)
            {
                char charim = char.Parse(Console.ReadLine());
                vs[i] = charim;
            }
            int[] amount = new int[26];
            for (int i = 0; i < vsLength; i++)
            {
                if ((int)vs[i] >= 97 && (int)vs[i] <= 123)
                    amount[(int)vs[i] - 97]++;
                else if ((int)vs[i] >= 65 && (int)vs[i] <= 91)
                    amount[(int)vs[i] - 65]++;
            }
            int lastCounter = amount[0];
            int check = 0;
            for (int i = 0; i < amount.Length; i++)
            {
                if (amount[i] == lastCounter)
                {
                    check++;
                }
            }
            if (check == vsLength)
                Console.WriteLine("there is izogram.");
            else
                Console.WriteLine("there is no izogram.");
            check = 0;
            for (int i = 0; i < amount.Length; i++)
            {
                if (amount[i] == 0)
                {
                    check++;
                }
            }
            if (check == 0)
                Console.WriteLine("There is penegram");
            else
                Console.WriteLine("There is no penegram");
            Console.ReadKey();
        }
    }
}
//זכויות יוצרים למגניבים המדליקים
