using System;

namespace everylessons
{
    class Program
    {
        public static bool Takin (Domino [] dominos)
        {
            
            for (int i = 1; i < dominos.Length; i++)
            {
                if (dominos[i].GetRight() != dominos[i - 1].GetLeft())
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

        }
    }
}
//זכויות יוצרים למגניבים המדליקים   