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
using TextBasedAdventure_WinForms.Properties;

//**FIGURE OUT WHICH SYSTEM CONTROL TO USE FOR CUSTOM EXCEPTIONS**
// using System.TextBasedAdventure_WinForms.Exceptions;

namespace TextBasedAdventure_WinForms
{
    public partial class Form1 : Form
    {
        public StoryController sc = new StoryController();
        // Form1 Constructor.
        public Form1()
        {
            InitializeComponent();
        }

        // When the Form window Loads...
        public void Form1_Load(object sender, EventArgs e)
        {

            this.ActiveControl = playerConsole;
            gameConsole.AppendText( "The Lord of the Rings : The Fellowship of the Ring!\n");
            gameConsole.AppendText("Who are you?\n");
            gameConsole.AppendText("Frodo\n" + "Sam\n" + "Merry\n" + "Pippin\n");
            sc.PlayerHasName = false;
            sc.MoveToNext = false;
        }
        public void gameConsole_TextChanged(object sender, EventArgs e)
        {

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

        // When a specific key (enter) is pressed.
        public void playerConsole_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Only Send text to the Game Console if there is (some criteria) included.



            if (e.KeyChar == (char)Keys.Enter && playerConsole.Text.Trim().Length != 0)
            {
                // Make sure input is bigger than 5, smaller than 25 characters.
                if (playerConsole.Text.Length > 25)
                {
                    gameConsole.AppendText("Input too long.\n");
                    playerConsole.Text = "";
                    e.Handled = true;
                } else if (playerConsole.Text.Trim().Length > 2)
                {
                    gameConsole.AppendText(playerConsole.Text + "\n");
                    playerConsole.Text = "";
                    e.Handled = true;
                }
                if (sc.PlayerHasName == false)
                {
                    if (playerConsole.Text == "FRODO")
                    {
                        sc.PlayerHasName = true;
                        if (sc.PlayerHasName)
                        {

                        }
                    }
                    /*
                            playerCharacterTextBox.Text = "You are " + playerConsole.Text + "\n";
                            playerConsole.Text = "";
                            e.Handled = true;
                    else if (playerConsole.Text == "Sam")
                        sc.PlayerHasName = true;
                        if (sc.PlayerHasName)
                            playerCharacterTextBox.Text = "You are " + playerConsole.Text + "\n";
                            playerConsole.Text = "";
                            e.Handled = true;
                    else if (playerConsole.Text == "MERRY")
                        sc.PlayerHasName = true;
                        if (sc.PlayerHasName)
                            playerCharacterTextBox.Text = "You are " + playerConsole.Text + "\n";
                        playerConsole.Text = "";
                        e.Handled = true;
                    else if (playerConsole.Text == "PIPPIN")
                        sc.PlayerHasName = true;
                        if (sc.PlayerHasName)
                            playerCharacterTextBox.Text = "You are " + playerConsole.Text + "\n";
                            playerConsole.Text = "";
                            e.Handled = true;
                            */
                }
            }
        }
    }
}
