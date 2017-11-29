using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBasedAdventure_WinForms.Exceptions;
//**FIGURE OUT WHICH SYSTEM CONTROL TO USE FOR CUSTOM EXCEPTIONS**
// using System.TextBasedAdventure_WinForms.Exceptions;

namespace TextBasedAdventure_WinForms
{
    public partial class Form1 : Form
    {
        public bool returnPressed = false;
        public bool gameLaunchCheck = false;
        public Character character = new Character();
        public bool CharacterChosen;
        public bool ConsoleTextSentToLabel;
        public bool CanType;
        public bool promptCleared;
        public bool gameLaunched = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Overall form Listener... Probably won't work at all C:!
        public Form1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if Game has started, and greet player.
            gameLaunchCheck = false;
            gameConsole.AppendText( "Hello, press \"Enter\" to begin . . .\n");
        }

        // When text is changed in PLAYER-CONSOLE
        public void playerConsole_TextChanged(object sender, EventArgs e)
        {
            // If player hasn't typed anything, disable return button.
            if (playerConsole.Text == "")
                returnButton.Enabled = false;
            else if (playerConsole.Text != "")
                returnButton.Enabled = true;
            /*
            if (returnButton.Enabled)
            {
                if (ConsoleTextSentToLabel)
                {
                    if (gameConsole.Text.Contains(character.Name))
                    {

                    }
                }
                else return;
            }
            else return;
            */
        }

        // When "ENTER" is pressed...
        public void returnButton_Click(object sender, EventArgs e)
        {
            SendPlayerInputToGameConsole();
            returnPressed = true;
        }

        // Function for sending text from Player console, to Game Console
        public void SendPlayerInputToGameConsole()
        {
            gameConsole.AppendText("> " + playerConsole.Text + "\n");
            ConsoleTextSentToLabel = true;
            if (ConsoleTextSentToLabel)
                playerConsole.Text = "";
        }

        // When text is changed in GAME-CONSOLE
        private void gameConsole_TextChanged(object sender, EventArgs e)
        {
        }

        public void gameLaunch()
        {
            gameLaunched = false;
            if (returnPressed)
                gameLaunchCheck = true;
            // Initiate prompting player for character choice.
            if (gameLaunchCheck)
                PromptPlayer();
                gameConsole.AppendText("");
                gameLaunched = true;
                playerConsole.Enabled = true;
        }

        public void PromptPlayer()
        {
            if (returnPressed)
                gameConsole.AppendText("Choose a character: \n" + "\n" +
                    "Frodo, Sam, Merry, Pippin?\n\n");
            promptCleared = true;
        }
        public string ChooseCharacter()
        {
            string result = "";

            PreGame intro = new PreGame();
            return result;
        }



// MENU STRIPS \\

        // Restart application
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerConsole.ResetText();
            gameConsole.ResetText();
        }
        // Clear all labels
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Restart();
        }
        // Exit application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Open Readme file
        private void openReadmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Readme file.
        }
    }
}
