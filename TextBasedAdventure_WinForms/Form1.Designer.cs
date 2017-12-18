namespace TextBasedAdventure_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerConsole = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameConsole = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.playerCharacterTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerConsole
            // 
            this.playerConsole.BackColor = System.Drawing.Color.Navy;
            this.playerConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerConsole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.playerConsole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.playerConsole.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerConsole.ForeColor = System.Drawing.Color.White;
            this.playerConsole.Location = new System.Drawing.Point(36, 209);
            this.playerConsole.Name = "playerConsole";
            this.playerConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerConsole.Size = new System.Drawing.Size(1011, 23);
            this.playerConsole.TabIndex = 0;
            this.playerConsole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerConsole_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2880, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReadmeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openReadmeToolStripMenuItem
            // 
            this.openReadmeToolStripMenuItem.Name = "openReadmeToolStripMenuItem";
            this.openReadmeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openReadmeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openReadmeToolStripMenuItem.Text = "Open Readme";
            this.openReadmeToolStripMenuItem.Click += new System.EventHandler(this.openReadmeToolStripMenuItem_Click);
            // 
            // gameConsole
            // 
            this.gameConsole.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gameConsole.BackColor = System.Drawing.Color.LightSeaGreen;
            this.gameConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameConsole.CausesValidation = false;
            this.gameConsole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameConsole.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameConsole.ForeColor = System.Drawing.Color.Black;
            this.gameConsole.Location = new System.Drawing.Point(0, 28);
            this.gameConsole.Multiline = true;
            this.gameConsole.Name = "gameConsole";
            this.gameConsole.ReadOnly = true;
            this.gameConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameConsole.Size = new System.Drawing.Size(2049, 600);
            this.gameConsole.TabIndex = 4;
            this.gameConsole.TextChanged += new System.EventHandler(this.gameConsole_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.playerConsole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2049, 244);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "> ";
            // 
            // playerCharacterTextBox
            // 
            this.playerCharacterTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.playerCharacterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerCharacterTextBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCharacterTextBox.Location = new System.Drawing.Point(676, 631);
            this.playerCharacterTextBox.Name = "playerCharacterTextBox";
            this.playerCharacterTextBox.Size = new System.Drawing.Size(289, 23);
            this.playerCharacterTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2880, 900);
            this.Controls.Add(this.playerCharacterTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameConsole);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Based Adventure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox playerConsole;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerCharacterTextBox;
        public System.Windows.Forms.TextBox gameConsole;
        public System.Windows.Forms.Panel panel1;
    }
}

