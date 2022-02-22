using DiceGame.Windows;
using DiceGame.Windows90;
using System;
using DiceGame.Game_Units;
using DiceGame.Controllers;
using DiceGame.GUI;

namespace DiceGame
{
    class Program
    {
        static void Main()
        {
            MenuController myMeniuController = new MenuController();
            Console.CursorVisible = false;
            myMeniuController.ShowMainMenu();
            
        }


    }
}
