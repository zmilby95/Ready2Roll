using System;
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

    class Program
    {
        static void Main(string[] args)
        {

            DiceRoll fourSided = new DiceRoll(4);
            DiceRoll sixSided = new DiceRoll(6);
            DiceRoll tenSided = new DiceRoll(10);
            DiceRoll twelveSided = new DiceRoll(12);
            DiceRoll twentySided = new DiceRoll(20);

            

        }
    }

}

