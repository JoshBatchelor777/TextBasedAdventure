using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBasedAdventure_WinForms.Properties;

namespace TextBasedAdventure_WinForms
{
    public class StoryController : EventArgs
    {
        public bool PlayerHasName { get; set; }
        public bool MoveToNext { get; set; }

        public StoryController()
        {
            PlayerHasName = new bool();
            MoveToNext = new bool();
        }
    }
}
