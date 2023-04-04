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
        {
         Random random = new Random();
         return random.Next(1, sides + 1);
        }
    }

}
