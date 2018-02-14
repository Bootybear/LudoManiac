using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoManiac
{
    class Dice
    {
        //Dice value
        private Random rng = new Random();
        private int diceValue;

        //Constructor to throw dice
        public Dice()
        {
            this.diceValue = this.rng.Next(1, 7);
        }

        //Method to throw dice
        public int ThrowDice()
        {
            this.diceValue = this.rng.Next(1, 7);

            for (int i = 3; i > 0; i--)
            {
                Console.Write(" . ");
                System.Threading.Thread.Sleep(500);
            }

            return this.diceValue;
        }

        //Checks dice value
        public int GetValue()
        {
            return this.diceValue;
        }

    }
}
