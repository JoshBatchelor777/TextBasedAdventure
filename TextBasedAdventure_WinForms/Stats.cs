using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure_WinForms
{
    
    public class Stat
    {
        public Random _random { get; set; }
        public int HealthPoints { get; set; }
        public int DefensePower { get; set; }
        public int AttackPower { get; set; }
        public int Luck { get; set; }

        public Stat()
        {
            _random = new Random();

        }


    }
}
