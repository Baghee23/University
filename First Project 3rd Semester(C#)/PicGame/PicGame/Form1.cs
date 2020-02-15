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

namespace PicGame
{
    public partial class Form1 : Form
    {
        //construct a "player" in order to activate sounds 
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            //connect the player with the path of the mp3 file 
            player.URL = Environment.CurrentDirectory + "/" + "song.mp3";
            //activate the player 
            player.controls.play();

        }
        //Initiallize variables 
        //PN=name given by the user
        //rB=radioButton selected 
        //score=Score points of the users after playing in a level of the game 
        string PN;
        bool fl;
        public static int rB;
        int score;



        private void Form1_Load(object sender, EventArgs e)
        {
            //demonstrate the current time to the main menu 
            label1.Text = DateTime.Now.ToString();
            richTextBox2.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open a txt file containning instructions of the game 
            richTextBox2.Text = File.ReadAllText("Instructions.txt");
            richTextBox2.Show();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //open a txt file containning info about the game 
            richTextBox2.Text = File.ReadAllText("About.txt");
            richTextBox2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if the input is not valid 
            if (fl == false)
            {
                MessageBox.Show("Please fill the Box with a name!");
            }
            else
            {
                //for each option open the new form and transfer data through the constructor 
                if (radioButton1.Checked)
                {
                    rB = 1;
                    //Stop the background music 
                    player.controls.stop();
                    //Open the new form which contains the game
                    Form2 f2 = new Form2(PN, score);
                    this.Hide();
                    f2.ShowDialog();


                }
                else if (radioButton2.Checked)
                {
                    rB = 2;
                    //Stop the background music 
                    player.controls.stop();
                    //Open the new form which contains the game
                    Form f2 = new Form2(PN, score);
                    this.Hide();
                    f2.ShowDialog();


                }
                else if (radioButton3.Checked)
                {
                    rB = 3;
                    //Stop the background music 
                    player.controls.stop();
                    //Open the new form which contains the game
                    Form f2 = new Form2(PN, score);
                    this.Hide();
                    f2.ShowDialog();


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PN = textBox1.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check the input of the user
            if (textBox1.Text.Length == 0 && e.KeyChar == ' ' && !char.IsControl(e.KeyChar) && textBox1.Text == "  ")
            {
                fl = false;
                e.Handled = true;
            }
            else
            {
                fl = true;
                e.Handled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Demonstrate the score points of every user in the "Easy" level to the richTextBox1
            richTextBox1.Clear();
            //Get the data from the txt file 
            string[] highscore = File.ReadAllText("high1.txt").Split(new string[] { "\n" }, StringSplitOptions.None);
            scoreText(highscore);
        }
        //Method for sorting out the files to demonstrate the top scores on top for each level 
        private void scoreText(string[] highscore)
        {
            string[] name = new string[highscore.Length];
            int[] score = new int[highscore.Length];
            if (highscore.Length == 1 && highscore[0] == "")
            {
                richTextBox1.AppendText("No scores yet");
            }
            else
            {
                for (int i = 0; i < highscore.Length; i++)
                {
                    string[] divide = highscore[i].Split(new string[] { "|" }, StringSplitOptions.None);
                    name[i] = divide[1];
                    score[i] = Int32.Parse(divide[0]);
                }
                Array.Sort(score, name);
                for (int i = highscore.Length - 1; i >= 0; i--)
                {
                    richTextBox1.AppendText(name[i] + "|" + score[i] + "\n");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Demonstrate the score points of every user in the "Medium" level to the richTextBox1
            richTextBox1.Clear();
            string[] highscore = File.ReadAllText("high2.txt").Split(new string[] { "\n" }, StringSplitOptions.None);
            scoreText(highscore);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Demonstrate the score points of every user in the "Hard" level to the richTextBox1
            richTextBox1.Clear();
            string[] highscore = File.ReadAllText("high3.txt").Split(new string[] { "\n" }, StringSplitOptions.None);
            scoreText(highscore);
        }
    }
}
