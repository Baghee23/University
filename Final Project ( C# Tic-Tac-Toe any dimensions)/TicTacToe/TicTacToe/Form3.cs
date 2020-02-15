using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "This game was created as a University of Piraeus Project by 3 students of the Computer Science Department.These three students are Fotis Stavropoulos,Eva PK,Chris Katevas and you can find information about them and their projects on their personal github repos." + "\n" + "Their github repos are displayed below:";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void Git1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Baghee23");
        }

        private void Git3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            Process.Start("https://github.com/katevaschris");
        }

        private void Git2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Evaggelia18");
        }
    }
}
