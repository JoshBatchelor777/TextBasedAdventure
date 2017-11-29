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
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerConsole = new System.Windows.Forms.TextBox();
            this.oldConsole = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameConsole = new System.Windows.Forms.TextBox();
            this.playerGroupBox.SuspendLayout();
            this.oldConsole.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.playerConsole);
            this.playerGroupBox.Location = new System.Drawing.Point(13, 436);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(544, 164);
            this.playerGroupBox.TabIndex = 0;
            this.playerGroupBox.TabStop = false;
            // 
            // playerConsole
            // 
            this.playerConsole.BackColor = System.Drawing.Color.Black;
            this.playerConsole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.playerConsole.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.playerConsole.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerConsole.ForeColor = System.Drawing.Color.Lime;
            this.playerConsole.Location = new System.Drawing.Point(6, 19);
            this.playerConsole.Multiline = true;
            this.playerConsole.Name = "playerConsole";
            this.playerConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerConsole.Size = new System.Drawing.Size(532, 139);
            this.playerConsole.TabIndex = 0;
            this.playerConsole.UseWaitCursor = true;
            this.playerConsole.TextChanged += new System.EventHandler(this.playerConsole_TextChanged);
            // 
            // oldConsole
            // 
            this.oldConsole.AutoScroll = true;
            this.oldConsole.BackColor = System.Drawing.Color.Black;
            this.oldConsole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oldConsole.Controls.Add(this.resultLabel);
            this.oldConsole.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldConsole.ForeColor = System.Drawing.Color.Lime;
            this.oldConsole.Location = new System.Drawing.Point(19, 402);
            this.oldConsole.Name = "oldConsole";
            this.oldConsole.Size = new System.Drawing.Size(1009, 35);
            this.oldConsole.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Lime;
            this.resultLabel.Location = new System.Drawing.Point(3, 1);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(73, 23);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "output:";
            // 
            // returnButton
            // 
            this.returnButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.returnButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(957, 562);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(38, 38);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Execute";
            this.returnButton.UseCompatibleTextRendering = true;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
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
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            this.gameConsole.BackColor = System.Drawing.Color.Black;
            this.gameConsole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gameConsole.Cursor = System.Windows.Forms.Cursors.No;
            this.gameConsole.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameConsole.ForeColor = System.Drawing.Color.Lime;
            this.gameConsole.Location = new System.Drawing.Point(19, 28);
            this.gameConsole.Multiline = true;
            this.gameConsole.Name = "gameConsole";
            this.gameConsole.ReadOnly = true;
            this.gameConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameConsole.Size = new System.Drawing.Size(1009, 358);
            this.gameConsole.TabIndex = 4;
            this.gameConsole.TextChanged += new System.EventHandler(this.gameConsole_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.returnButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 612);
            this.Controls.Add(this.gameConsole);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.oldConsole);
            this.Controls.Add(this.playerGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Based Adventurre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            this.oldConsole.ResumeLayout(false);
            this.oldConsole.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.Panel oldConsole;
        public System.Windows.Forms.Button returnButton;
        public System.Windows.Forms.Label resultLabel;
        public System.Windows.Forms.TextBox playerConsole;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmeToolStripMenuItem;
        private System.Windows.Forms.TextBox gameConsole;
    }
}

