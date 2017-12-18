using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure_WinForms
{
    public class Character
    {
        public string Name { get; set; } 
        public Stat stat { get; set; }


        public Character()
        {
            stat = new Stat();
            stat.HealthPoints = stat._random.Next(20, 50);
            stat.DefensePower = stat._random.Next(10, 30);
            stat.AttackPower = stat._random.Next(30, 40);
            stat.Luck = stat._random.Next(5, 10);
        }
    }
}
