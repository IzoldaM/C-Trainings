using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Windows90
{
    class PlayerSelectionMenu: Window
    {
        private TextBlock titleTextBlock;
        List<Button> listOfPlayers = new List<Button>();

        public PlayerSelectionMenu() : base(0, 0, 120, 30, '%')
        {


            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Select number of players from 2 to 7" });
            listOfPlayers.Add(new Button(30, 13, 18, 5, Players.P2.ToString()));
            listOfPlayers.Add(new Button(47, 13, 18, 5, Players.P3.ToString()));
            listOfPlayers.Add(new Button(64, 13, 18, 5, Players.P4.ToString()));
            listOfPlayers.Add(new Button(30, 17, 18, 5, Players.P5.ToString()));
            listOfPlayers.Add(new Button(47, 17, 18, 5, Players.P6.ToString()));
            listOfPlayers.Add(new Button(64, 17, 18, 5, Players.P7.ToString()));
            listOfPlayers.ElementAt(0).SetActive();
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();

            foreach (Button button in listOfPlayers)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public string GetSelectedOption()
        {
            foreach (Button button in listOfPlayers)
            {
                if (button.IsActive == true)
                {
                    return button.Label;
                }

            }
            //if no active button
            return null;
        }

        public void SetSelectedOption(string label)
        {
            foreach (Button button in listOfPlayers)
            {
                if (button.Label == label)
                {
                    button.SetActive();
                }
                else
                {
                    button.IsActive = false;
                }
            }
        }
    }
}
