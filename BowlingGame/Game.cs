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

        private int[] rolls = new int[21];
        private int currentRoll = 0;

        static void Main(string[] args)
        {
        }

        public void roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int score()
        {
            int totalPins = 0;
            for (int i = 0; i < rolls.Length; i++)
            {
                totalPins += rolls[i];
            }
            return totalPins;
        }
    }
}
