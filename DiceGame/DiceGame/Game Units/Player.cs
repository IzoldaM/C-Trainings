using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game_Units
{
    class Player
    {
        public string Name { get; }
        public int Id { get; }
    
    public Player(string name, int id)
    {
        Name = name;
        Id = id;

    }
}
}
