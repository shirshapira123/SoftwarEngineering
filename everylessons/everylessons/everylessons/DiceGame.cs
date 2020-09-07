using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class DiceGame
    {
        Dice dice1, dice2;
        int times = 0;
        public DiceGame(Dice dice1, Dice dice2)
        {
            this.dice1 = dice1;
            this.dice2 = dice2;
        }
        public string Rolling()
        {
            times++;
            dice1.Roll();
            dice2.Roll();
            return ("(" + dice1.GetNum() + "," + dice2.GetNum() + ")");
        }
        public bool WinOrNot()
        {
            if (dice1.GetNum() == 6 && dice2.GetNum() == 6)
                return true;
            return false;
        }
        public int GetTimes() => times;
    }
}
