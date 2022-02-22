using DiceGame.Windows;
using DiceGame.Windows90;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Controllers
{
    class MenuController
    {
        MainMeniu myMainMenu;
        PlayerSelectionMenu myPlayerSelectionMenu;
        DiceSelectionMenu myDiceSelectionMenu;
        GameOverMenu myGameOverMeniu;
        int numberofPlayers=2;
        int numberofDices;

        GameController myGame;


        public MenuController()
        {
            myMainMenu = new MainMeniu();
            myPlayerSelectionMenu = new PlayerSelectionMenu();
            myDiceSelectionMenu = new DiceSelectionMenu();
            myGameOverMeniu = new GameOverMenu();
        }


        public void ShowMainMenu()
        {
            Console.CursorVisible = false;
            myMainMenu.Render();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.P)
                {
                    ShowPlayersSelectionMeniu();
                }
                else if (cki.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("Your game is about to quit");
                    Environment.Exit(0);
                }
            } while (cki.Key != ConsoleKey.P || cki.Key != ConsoleKey.Q);
        }

        public void ShowPlayersSelectionMeniu()
        {
            myPlayerSelectionMenu.Render();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (myPlayerSelectionMenu.GetSelectedOption() == "P2")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P2");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P3")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P2");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P4")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P3");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P5")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P5");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P6")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P5");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P7")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P6");
                        myPlayerSelectionMenu.Render();
                    }
                }
                else if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (myPlayerSelectionMenu.GetSelectedOption() == "P2")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P3");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P3")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P4");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P4")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P4");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P5")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P6");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P6")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P7");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P7")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P7");
                        myPlayerSelectionMenu.Render();
                    }
                }
                else if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (myPlayerSelectionMenu.GetSelectedOption() == "P2")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P5");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P3")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P6");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P4")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P7");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P5")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P5");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P6")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P6");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P7")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P7");
                        myPlayerSelectionMenu.Render();
                    }

                }
                else if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (myPlayerSelectionMenu.GetSelectedOption() == "P2")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P2");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P3")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P3");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P4")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P4");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P5")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P2");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P6")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P3");
                        myPlayerSelectionMenu.Render();
                    }
                    else if (myPlayerSelectionMenu.GetSelectedOption() == "P7")
                    {
                        myPlayerSelectionMenu.SetSelectedOption("P4");
                        myPlayerSelectionMenu.Render();

                    }

                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    numberofPlayers = Convert.ToInt32(myPlayerSelectionMenu.GetSelectedOption().Substring(1, 1));
                    ShowDiceSelectionMenu();
                }
                
            }
            while (cki.Key != ConsoleKey.Enter);

        }

        public void ShowDiceSelectionMenu()
        {
            myDiceSelectionMenu.Render();
            ConsoleKeyInfo cki;
            do{
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.OemPlus)
                {
                    myDiceSelectionMenu.NumberOfDices += 1;
                    myDiceSelectionMenu.Render();
                }
                else if (cki.Key == ConsoleKey.OemMinus)
                {
                    myDiceSelectionMenu.NumberOfDices -= 1;
                    if (myDiceSelectionMenu.NumberOfDices <= 0)
                    {
                        myDiceSelectionMenu.NumberOfDices = 1;
                    }
                    myDiceSelectionMenu.Render();
                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    numberofDices = myDiceSelectionMenu.NumberOfDices;
                    PlayTheGame(numberofPlayers, numberofDices);

                }

            } while (cki.Key != ConsoleKey.Enter);
        }

        public void ShowGameOverMeniu()
        {
            myGameOverMeniu.Render();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.R)
                {
                    PlayTheGame(numberofPlayers, numberofDices);
                }
                else if (cki.Key == ConsoleKey.M)
                {
                    ShowMainMenu();
                }
                else if (cki.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("Your game is about to quit");
                    Environment.Exit(0);
                }

            } while (cki.Key != ConsoleKey.R || cki.Key != ConsoleKey.M || cki.Key != ConsoleKey.Q);
        }
        public void PlayTheGame(int numberofPlayers, int numberofDices)
        {
            myGame = new GameController(numberofPlayers, numberofDices);
            myGame.StartGame();
            System.Threading.Thread.Sleep(2750);
            Console.Clear();
            ShowGameOverMeniu();
        }

        
    }
}
