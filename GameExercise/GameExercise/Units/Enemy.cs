using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExercise.Units
{
    class Enemy : Unit
    {
        private int id;
        //private int x;
        //private int y;
        //private string name;
        
        public Enemy (int id, int x, int y, string name): base(x, y, name)
        {
            this.id = id;
           //this.x = x;
           //this.y = y;
           //this.name = name;
        }

        public void MoveDown()
        {
            Y--;
        }

        /*public void PrintInfo()
        {
            Console.WriteLine($"{name} enemy with id {id} is at point {x},{y}");
        }*/

        public int GetId()
        {
            return id;
        }
    }
}
