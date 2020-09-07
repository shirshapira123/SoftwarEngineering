using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            DiceGame diceGame = new DiceGame(dice1, dice2);
            bool flag = false;
            while (!flag)
            {
                Console.ReadKey();
                Console.Write("roll number " + diceGame.GetTimes() + ":");
                string rolling = diceGame.Rolling();
                Console.WriteLine(rolling);
                flag = diceGame.WinOrNot();
                if (!flag)
                {
                    Console.WriteLine("You lose this round, try again");
                }
            }
            Console.WriteLine("YOU WIN THE GAME!!, you rolled the dice " + (diceGame.GetTimes()-1) + " times.");
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   