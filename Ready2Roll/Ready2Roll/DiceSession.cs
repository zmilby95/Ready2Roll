using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready2Roll
{
    public class DiceSession
    {
        public int total;
        public List<Dice> diceList;
        public DateTime date;

        public DiceSession()
        {
            date = DateTime.Now;
        }
    }
}
