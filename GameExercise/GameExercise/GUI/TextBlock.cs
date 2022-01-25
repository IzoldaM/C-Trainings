using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExercise.GUI
{
     class TextBlock : GuiObject
    {
        private List<TextLine> textLines = new List<TextLine>();

        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textLines.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }

        public override void Render()
        {
            for (int i = 0; i < textLines.Count; i++)
            {
                textLines[i].Render();
            }
        }
    }
}
