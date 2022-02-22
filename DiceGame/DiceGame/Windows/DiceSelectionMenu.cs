using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Windows
{
    class DiceSelectionMenu : Window
    {
        private TextLine diceTextLine;
        public int NumberOfDices { get; set; } = 1;

        public DiceSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            diceTextLine = new TextLine(10, 15, 50, diceSelectionString(1));

        }

        public string diceSelectionString(int dices)
        {
            return "Players will have " + dices.ToString() + " dice(s). Use +/- to change the number. Press enter to start the game.";
        }

        public override void Render()
        {
            base.Render();
            diceTextLine.Label = diceSelectionString(NumberOfDices);
            diceTextLine.Render();
            Console.SetCursorPosition(0, 0);
        }
    }
}
