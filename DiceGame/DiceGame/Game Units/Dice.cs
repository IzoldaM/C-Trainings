using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game_Units
{
    abstract class Dice
    {
        public int NumberofSides { get; set; }


        public Dice(int numberoSides)
        {
            NumberofSides = numberoSides;
        }

        abstract public int RollTheDice();
    }
}
