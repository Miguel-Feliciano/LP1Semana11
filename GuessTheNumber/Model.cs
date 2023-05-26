using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Model
    {
        private int targetNumber;
        public int Attempts { get; private set; }

        public void GenerateRandomNumber()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101);
        }

        public bool CheckGuess(int guess)
        {
            Attempts++;

            if (guess == targetNumber)
            {
                return true;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }

            return false;
        }
    }
}