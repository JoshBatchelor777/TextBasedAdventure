using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// REFACTOR GAME FLOW (ie the timline) WITH NEW GAME CLASSES. DIVI UP RESPONSIBILITIES.


namespace TextBasedAdventure_WinForms
{
    public class PreGame
    {
        public Character character { get; set; }
        public bool IntroComplete = false;

        public PreGame()
        {
            character = new Character();
        }
    }
}
