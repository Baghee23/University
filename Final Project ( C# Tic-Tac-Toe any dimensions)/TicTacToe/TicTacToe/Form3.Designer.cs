namespace TicTacToe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Git1 = new System.Windows.Forms.LinkLabel();
            this.Git2 = new System.Windows.Forms.LinkLabel();
            this.Git3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Calisto MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(259, 297);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(192, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return to Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Git1
            // 
            this.Git1.AutoSize = true;
            this.Git1.BackColor = System.Drawing.Color.Transparent;
            this.Git1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Git1.LinkColor = System.Drawing.Color.White;
            this.Git1.Location = new System.Drawing.Point(12, 323);
            this.Git1.Name = "Git1";
            this.Git1.Size = new System.Drawing.Size(138, 16);
            this.Git1.TabIndex = 2;
            this.Git1.TabStop = true;
            this.Git1.Text = "Fotis Stavropoulos";
            this.Git1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Git1_LinkClicked);
            // 
            // Git2
            // 
            this.Git2.AutoSize = true;
            this.Git2.BackColor = System.Drawing.Color.Transparent;
            this.Git2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Git2.LinkColor = System.Drawing.Color.White;
            this.Git2.Location = new System.Drawing.Point(12, 355);
            this.Git2.Name = "Git2";
            this.Git2.Size = new System.Drawing.Size(58, 16);
            this.Git2.TabIndex = 3;
            this.Git2.TabStop = true;
            this.Git2.Text = "Eva PK";
            this.Git2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Git2_LinkClicked);
            // 
            // Git3
            // 
            this.Git3.AutoSize = true;
            this.Git3.BackColor = System.Drawing.Color.Transparent;
            this.Git3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Git3.LinkColor = System.Drawing.Color.White;
            this.Git3.Location = new System.Drawing.Point(12, 392);
            this.Git3.Name = "Git3";
            this.Git3.Size = new System.Drawing.Size(103, 16);
            this.Git3.TabIndex = 4;
            this.Git3.TabStop = true;
            this.Git3.Text = "Chris Katevas";
            this.Git3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Git3_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 488);
            this.ControlBox = false;
            this.Controls.Add(this.Git3);
            this.Controls.Add(this.Git2);
            this.Controls.Add(this.Git1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Git1;
        private System.Windows.Forms.LinkLabel Git2;
        private System.Windows.Forms.LinkLabel Git3;
    }
}