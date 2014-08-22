using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {        
        private List<int> rolls = new List<int>();

        static void Main(string[] args)
        {
        }

        public void roll(int pins)
        {            
            rolls.Add(pins);            
        }

        public int score()
        {
            int totalPins = 0;
            int position = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(position))
                {
                    totalPins += 10 + strikeBonus(position);
                    position++;
                }
                else if (isSpare(position))
                {
                    totalPins += 10 + spareBonus(position);
                    position += 2;
                }
                else
                {
                    totalPins += pinsAtFrame(position);
                    position += 2;
                }
            }
            return totalPins;
        }

        public bool isSpare(int currentPosition)
        {
            return rolls[currentPosition] + rolls[currentPosition+1] == 10;
        }

        public bool isStrike(int currentPosition)
        {
            return rolls[currentPosition] == 10;
        }

        public int spareBonus(int position)
        {
            return rolls[position + 2];
        }

        public int strikeBonus(int position)
        {
            return rolls[position + 1] + rolls[position + 2];
        }

        public int pinsAtFrame(int position)
        {
            return rolls[position] + rolls[position + 1];
        }
    }
}
