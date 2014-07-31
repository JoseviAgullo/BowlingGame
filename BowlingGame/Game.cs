using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int totalPins = 0;

        static void Main(string[] args)
        {
        }

        public void roll(int pins)
        {
            totalPins += pins;
        }

        public int score()
        {
            return totalPins;
        }
    }
}
