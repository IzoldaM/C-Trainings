using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Windows
{
    sealed class MainMeniu : Window
    {
        List<Button> listOfButtons = new List<Button>();
        const string start = "Play (press P)";
        const string quit = "Quit (press Q)";

        public MainMeniu() : base(0, 0, 120, 30, '%')
        {
            
            listOfButtons.Add(new Button(20, 13, 18, 5, start));

            listOfButtons.Add(new Button(80, 13, 18, 5, quit));
        }

        public override void Render()
        {
            base.Render();

            foreach (Button button in listOfButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }


    }
}
