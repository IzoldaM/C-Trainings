using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExercise.Units
{
    class Hero : Unit
    {
        //private int x;
        //private int y;
        //private string name;

        public Hero(int x, int y, string name) : base(x, y, name)
        {
            //this.x = x;
            //this.y = y;
            //this.name = name;
        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveLeft()
        {
            X--;
        }

        public int GetX()
        {
            return X;
        }

        /*public void PrintInfo()
        {
            Console.WriteLine($"{name} hero is at point {x},{y}");
        }*/


    }
}
