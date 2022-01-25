using GameExercise.Game;
using GameExercise.GUI;
using GameExercise.Units;
using System;
using System.Collections.Generic;

namespace GameExercise
{
    class Program
    {
        static void Main()
        {
            // GameController myGame = new GameController();
            //myGame.StartGame();

            //Console.CursorVisible = false;

            //MeniuWindow meniuWindow = new MeniuWindow();
            //meniuWindow.Render();

            //CreditWindow creditWindow = new CreditWindow();
            //creditWindow.Render();

            //Console.ReadKey();

            GuiController GController = new GuiController();
            Console.CursorVisible = false;
            GController.ShowMeniu();
            Console.ReadKey();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if( GController.MeniuWindow.GetSelectedButton() == "Credits")
                    {
                        GController.MeniuWindow.SetSelectedButton("Start");
                        GController.ShowMeniu();
                        //Console.ReadKey();
                    }
                    else if(GController.MeniuWindow.GetSelectedButton() == "Quit")
                    {
                        GController.MeniuWindow.SetSelectedButton("Credits");
                        GController.ShowMeniu();
                        //Console.ReadKey();
                    }
                }
                else if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (GController.MeniuWindow.GetSelectedButton() == "Start")
                    {
                        GController.MeniuWindow.SetSelectedButton("Credits");
                        GController.ShowMeniu();
                        //Console.ReadKey();
                    }
                    else if (GController.MeniuWindow.GetSelectedButton() == "Credits")
                    {
                        GController.MeniuWindow.SetSelectedButton("Quit");
                        GController.ShowMeniu();
                        //Console.ReadKey();
                    }
                }
                else if(cki.Key == ConsoleKey.Enter)
                {
                    if(GController.MeniuWindow.GetSelectedButton() == "Start")
                    {
                        GController.MyGame.StartGame();
                    }
                    else if (GController.MeniuWindow.GetSelectedButton() == "Credits")
                    {
                        
                        GController.CreditWindow.Render();
                        //cki = Console.ReadKey();
                        do
                        {
                            cki = Console.ReadKey();
                            if(cki.Key == ConsoleKey.Enter || cki.Key == ConsoleKey.Escape)
                            {
                                GController.ShowMeniu();
                            }
                            break;

                        } while (cki.Key != ConsoleKey.Enter || cki.Key != ConsoleKey.Escape);
                        
                                                
                    }
                    else if (GController.MeniuWindow.GetSelectedButton() == "Quit")
                    {
                        Console.Clear();
                        Console.WriteLine("Your game is about to quit");
                        Environment.Exit(0);
                    }

                }
            } while (cki.Key != ConsoleKey.LeftArrow || cki.Key != ConsoleKey.RightArrow || cki.Key != ConsoleKey.Enter);




        }
    }
}
