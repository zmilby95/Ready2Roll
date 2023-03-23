﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready2Roll
{
    public class DiceRoll
    {
        private Random random;
        private int sidesCount;

        public DiceRoll()
        {
            sidesCount = 6;
            random = new Random();
        }

        public DiceRoll(int sidesCount)
        {
            this.sidesCount = sidesCount;
            random = new Random();
        }

        public int GetSidesCount()
        {
            return sidesCount;
        }

        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }
    }
}    