using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Windows
{
    class GameOverMenu: Window
    {
        List<Button> listOfButtons = new List<Button>();
        const string replay = "Replay Game (press R)";
        const string meniu = "Go To Menu (press M)";
        const string quit = "Quit (press Q)";

        public GameOverMenu() : base(0, 0, 120, 30, '%')
        {

            listOfButtons.Add(new Button(20, 13, 25, 5, replay));
            listOfButtons.Add(new Button(50, 13, 25, 5, meniu));
            listOfButtons.Add(new Button(80, 13, 25, 5, quit));
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
