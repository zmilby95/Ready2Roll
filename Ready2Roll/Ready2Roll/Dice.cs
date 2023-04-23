using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready2Roll
{
    public class Dice
    {
        public int sides;
        public int roll()
        {//set up the roll to work with any number of sides
         Random random = new Random();
         return random.Next(1, sides + 1);
        }
    }
    //lets the user roll twice keeping the higher score
    public class AdvantageRoll : Dice
    {
        public int reroll;
    }
}
