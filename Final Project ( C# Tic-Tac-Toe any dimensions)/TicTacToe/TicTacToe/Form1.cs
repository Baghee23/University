using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        public static int rb;
        Stats s = new Stats();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); }
                
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f2 = new Form3();
            this.Hide();
            f2.ShowDialog();
        }

        private void eraseStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you'd like to erase all of your progress in the game so far?"+"\n"+"Your choice will be permanent and you won't be able to undo it!", "Last chance!!!Confirm your choice!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText("StatsAgainstPlayer.txt","0"+"|"+"0"+"|"+"0"+"\n");
                File.WriteAllText("StatsAgainstComp.txt", "0"+"|"+"0"+"|"+"0"+"\n");
                MessageBox.Show("Stats have been successfully deleted!");
                s.LoadStats(AgainstPlayerLbl, AgainstCompLbl);
            }
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("Help1.txt");
            richTextBox1.Show();
        }

        private void myStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("Help2.txt");
            richTextBox1.Show();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (AgaintCompOptionBtn.Checked)
            {
                rb = 1;
            }
            else if (TwoPlayersBtn.Checked)
            {
                rb = 2;
            }
            Form2 f2 = new Form2(rb);
            this.Hide();
            f2.ShowDialog();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            s.LoadStats(AgainstPlayerLbl,AgainstCompLbl);
        }

        
    }
}
