using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExercise.GUI
{
    sealed class MeniuWindow : Window
    {
        //private Button startButton;
        //private Button creditsButton;
        //private Button quitButton;
        private TextBlock titleTextBlock;
        List<Button> listOfButtons = new List<Button>();


        public MeniuWindow() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "OOP example task - console game", "Developed by Izolda Motiejauskyte", "Made in Vilnius Coding School" });

            listOfButtons.Add(new Button(20, 13, 18, 5, "Start"));

            listOfButtons.Add(new Button(50, 13, 18, 5, "Credits"));

            listOfButtons.Add(new Button(80, 13, 18, 5, "Quit"));

            listOfButtons.ElementAt(0).SetActive();
        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            foreach(Button button in listOfButtons)
            {
                button.Render();
            }

            //startButton.Render();
            //creditsButton.Render();
            //quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

        public string GetSelectedButton()
        {
            foreach(Button button in listOfButtons)
            {
                if(button.IsActive == true)
                {
                    return button.Label;
                }

            }
            //if no active button
            return null;
        }

        public void SetSelectedButton(string label)
        {
            foreach(Button button in listOfButtons)
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
