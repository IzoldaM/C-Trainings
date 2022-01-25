using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameExercise.Units;
using GameExercise.GUI;
using GameExercise.Game;

namespace GameExercise.GUI
{
    class GuiController
    {
        MeniuWindow meniuWindow;
        CreditWindow creditWindow;
        GameController myGame = new GameController();

        public GuiController()
        {
            meniuWindow = new MeniuWindow();
            creditWindow = new CreditWindow();
        }
        
        public void ShowMeniu()
        {
            meniuWindow.Render();
        }

        public MeniuWindow MeniuWindow
        {
            get
            {
                return meniuWindow;
            }
            set
            {
                meniuWindow = value;
            }
        }

        public CreditWindow CreditWindow
        {
            get
            {
                return creditWindow;
            }
            set
            {
                creditWindow = value;
            }
        }

        public GameController MyGame
        {
            get
            {
                return myGame;
            }
            private set
            {
                myGame = value;
            }
        }


    }
}
