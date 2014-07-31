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
            int position = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isSpare(position))
                {
                    totalPins += 10 + rolls[position + 2];
                    position += 2;
                }
                else
                {
                    totalPins += rolls[position] + rolls[position + 1];
                    position += 2;
                }
            }
            return totalPins;
        }

        public bool isSpare(int currentPosition)
        {
            return rolls[currentPosition] + rolls[currentPosition+1] == 10;
        }
    }
}
