using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Dice
    {
        int num;
        Random rnd = new Random();
        public Dice()
        {
            num = rnd.Next(1, 7);
        }
        public void Roll()
        {
            num = rnd.Next(1, 7);
        }
        public int GetNum() => num;
    }
}
