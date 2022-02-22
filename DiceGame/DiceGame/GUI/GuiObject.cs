using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    abstract class GuiObject
    {
        /*protected int X;
        protected int Y;
        protected int Width;
        protected int Height;*/

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        //abstract method that has to be overwritten;
        abstract public void Render();
    }
}
