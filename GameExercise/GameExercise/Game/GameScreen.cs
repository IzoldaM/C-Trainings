using GameExercise.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExercise.Game
{
    class GameScreen
    {
        private int width;
        private int height;
        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();


        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public Hero GetHero()
        {
            return hero;
        }

        public void MoveHeroRight()
        {
            if(hero.GetX()< width)
            {
                hero.MoveRight();
            }

        }

        public void MoveHeroLeft()
        {
            if(hero.GetX() > 0)
            {
                hero.MoveLeft();
            }
            
        }
        
        public void AddEnemy (Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in enemies)
            {
                if(enemy.GetId() == id)
                {
                    return enemy;
                }
            }

            //return empty reference if no enemy with such id
            return null;
            
        }

        public void Render()
        {
            hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }
    }
}
