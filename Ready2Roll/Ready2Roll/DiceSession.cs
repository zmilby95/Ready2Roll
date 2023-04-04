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
        //created a list that will show the date and time and sort the rolls for the session 
        public DiceSession()
        {
            date = DateTime.Now;
        }
        public void displaySessionInfo() 
        {
            Console.WriteLine(date.ToString() + " Total of the roll: " + total);
        }
    }
}
