using GameExercise.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExercise.Game
{
    class GameController
    {
        private GameScreen myGame;

        public void StartGame()
        {

            // init game
            InitGame();

            // render loop
            StartGameLoop();
        }

        private void InitGame()
        {
            myGame = new GameScreen(30, 20);

            // fill game with game data.
            myGame.SetHero(new Hero(5, 5, "Hero0"));
            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
        }


        private void StartGameLoop()
        {
            bool needToRender = true;

            do
            {
                Console.Clear();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);


                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                    }
                }

                myGame.Render();

                System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }
}
}
