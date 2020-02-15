namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgaintCompOptionBtn = new System.Windows.Forms.RadioButton();
            this.TwoPlayersBtn = new System.Windows.Forms.RadioButton();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AgainstPlayerLbl = new System.Windows.Forms.Label();
            this.AgainstCompLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eraseStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO TIC-TAC-TOE MAIN MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select mode:";
            // 
            // AgaintCompOptionBtn
            // 
            this.AgaintCompOptionBtn.AutoSize = true;
            this.AgaintCompOptionBtn.BackColor = System.Drawing.Color.Transparent;
            this.AgaintCompOptionBtn.Checked = true;
            this.AgaintCompOptionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgaintCompOptionBtn.ForeColor = System.Drawing.Color.Red;
            this.AgaintCompOptionBtn.Location = new System.Drawing.Point(20, 113);
            this.AgaintCompOptionBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AgaintCompOptionBtn.Name = "AgaintCompOptionBtn";
            this.AgaintCompOptionBtn.Size = new System.Drawing.Size(258, 24);
            this.AgaintCompOptionBtn.TabIndex = 2;
            this.AgaintCompOptionBtn.TabStop = true;
            this.AgaintCompOptionBtn.Text = "PLAY AGAINST COMPUTER";
            this.AgaintCompOptionBtn.UseVisualStyleBackColor = false;
            // 
            // TwoPlayersBtn
            // 
            this.TwoPlayersBtn.AutoSize = true;
            this.TwoPlayersBtn.BackColor = System.Drawing.Color.Transparent;
            this.TwoPlayersBtn.ForeColor = System.Drawing.Color.Red;
            this.TwoPlayersBtn.Location = new System.Drawing.Point(20, 166);
            this.TwoPlayersBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TwoPlayersBtn.Name = "TwoPlayersBtn";
            this.TwoPlayersBtn.Size = new System.Drawing.Size(181, 24);
            this.TwoPlayersBtn.TabIndex = 3;
            this.TwoPlayersBtn.Text = "2 PLAYERS MODE";
            this.TwoPlayersBtn.UseVisualStyleBackColor = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlayBtn.ForeColor = System.Drawing.Color.Red;
            this.PlayBtn.Location = new System.Drawing.Point(20, 218);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(96, 33);
            this.PlayBtn.TabIndex = 4;
            this.PlayBtn.Text = "PLAY";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(393, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "YOUR STATS(Wins/Ties/Defeats)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(616, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Against Computer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(395, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Against another Player";
            // 
            // AgainstPlayerLbl
            // 
            this.AgainstPlayerLbl.AutoSize = true;
            this.AgainstPlayerLbl.BackColor = System.Drawing.Color.Transparent;
            this.AgainstPlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgainstPlayerLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.AgainstPlayerLbl.Location = new System.Drawing.Point(412, 85);
            this.AgainstPlayerLbl.Name = "AgainstPlayerLbl";
            this.AgainstPlayerLbl.Size = new System.Drawing.Size(88, 25);
            this.AgainstPlayerLbl.TabIndex = 8;
            this.AgainstPlayerLbl.Text = "SCORE";
            // 
            // AgainstCompLbl
            // 
            this.AgainstCompLbl.AutoSize = true;
            this.AgainstCompLbl.BackColor = System.Drawing.Color.Transparent;
            this.AgainstCompLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AgainstCompLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.AgainstCompLbl.Location = new System.Drawing.Point(640, 85);
            this.AgainstCompLbl.Name = "AgainstCompLbl";
            this.AgainstCompLbl.Size = new System.Drawing.Size(106, 25);
            this.AgainstCompLbl.TabIndex = 11;
            this.AgainstCompLbl.Text = "SCORE 2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eraseStatsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eraseStatsToolStripMenuItem
            // 
            this.eraseStatsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.eraseStatsToolStripMenuItem.Name = "eraseStatsToolStripMenuItem";
            this.eraseStatsToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.eraseStatsToolStripMenuItem.Text = "Erase Stats";
            this.eraseStatsToolStripMenuItem.Click += new System.EventHandler(this.eraseStatsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.myStatsToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // myStatsToolStripMenuItem
            // 
            this.myStatsToolStripMenuItem.Name = "myStatsToolStripMenuItem";
            this.myStatsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.myStatsToolStripMenuItem.Text = "My stats";
            this.myStatsToolStripMenuItem.Click += new System.EventHandler(this.myStatsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(416, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 210);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 335);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AgainstCompLbl);
            this.Controls.Add(this.AgainstPlayerLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.TwoPlayersBtn);
            this.Controls.Add(this.AgaintCompOptionBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AgaintCompOptionBtn;
        private System.Windows.Forms.RadioButton TwoPlayersBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AgainstPlayerLbl;
        private System.Windows.Forms.Label AgainstCompLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eraseStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myStatsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

