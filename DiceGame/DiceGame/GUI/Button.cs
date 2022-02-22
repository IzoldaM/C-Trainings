using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class Button : GuiObject
    {
        private Frame notActiveFrame;
        private Frame activeFrame;

        //private bool IsActive = false;
        public bool IsActive { get; set; } = false;
        private TextLine textLine;
        public string Label
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }
        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');
            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {
            if (IsActive)
            {
                //textLine.Label = "<<" + textLine.Label + ">>";
                activeFrame.Render();
            }
            else
            {
                // textLine.Label.Trim(new Char[] { '<', '>' });
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }
    }
}
