using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game_Units
{
    class DiceGroup
    {
        public List<int> groupOfDices { get; set; }
        string diceGroupName;
        public DiceGroup(string diceGroupName)
        {
            this.diceGroupName = diceGroupName;
            groupOfDices = new List<int>();
        }

        public int SumOfDices()
        {
            int result = 0;
            foreach (int diceresult in groupOfDices)
            {
                result += diceresult;
            }
            return result;
        }
   }
}
