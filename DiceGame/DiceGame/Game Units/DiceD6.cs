using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game_Units
{
    class DiceD6 : Dice
    {
        public DiceD6() : base(6)
        {
            base.NumberofSides = 6;
        }
        public override int RollTheDice()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(1, 6);
        }
    }
}
