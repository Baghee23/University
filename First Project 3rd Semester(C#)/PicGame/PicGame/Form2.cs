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
    public partial class Form2 : Form
    {
        //Initiallize a counter to let the user know how much time remains 
        int counter;
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        private bool f;
        string PN;
        int score;
        public Form2(string playerName , int plScore)
        {
            player2.URL = Environment.CurrentDirectory + "/" + "song3.mp3";
            player2.controls.play();
            PN = playerName;
            score = plScore;
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            
            pictureBox2.Hide();
            pictureBox3.Hide();
            label8.Text = Convert.ToString(score);
            label9.Text =PN;
            label10.Text =Convert.ToString(Form1.rB);
            if (Form1.rB == 1)
            {
                counter = 30;
                label7.Text = counter.ToString();


            }
            else if (Form1.rB == 2)
            { 
                counter = 60;
                label7.Text = counter.ToString();
            }
            else
            {
                counter = 90;
                label7.Text = counter.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            player2.controls.stop();
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Change the cursor to a cross only inside the panel borders 
            panel1.Cursor = Cursors.Cross;
            
            button1.Hide();
            player.URL = Environment.CurrentDirectory + "/" + "song2.mp3";
            player.controls.play();
            label5.Hide();
            timer1.Start();
            
            
        }
        //Initiallize a caseSwitch to control the levels depending on the selection of the user at the main menu
        private int caseSwitch = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            label6.Text =(int.Parse(label6.Text)-1).ToString();
            if (int.Parse(label6.Text) == 0)
            {
                
                pictureBox1.Show();
                if (Form1.rB == 2)
                {
                    pictureBox2.Show();
                }
                else if (Form1.rB == 3)
                {
                    pictureBox2.Show();
                    pictureBox3.Show();
                }
                f = true;
            }
            if (f)
            {


                label6.Hide();
                //Decrease the counter so the game ends someday :P 
                counter--;
                if (counter == 0)
                {

                    player.controls.stop();
                    
                    f = false;
                    label7.Text = counter.ToString();
                    timer1.Stop();
                    pictureBox1.Hide(); 
                    label6.Text = "OUT OF TIME!";
                    label6.Show();
                    label5.Show();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    if (Form1.rB == 1)
                    {
                        if (File.ReadAllText("high1.txt").Length == 0)
                        File.AppendAllText("high1.txt", score + "|" + PN);
                        else
                        File.AppendAllText("high1.txt", "\n"+ score + "|" + PN);
                    }
                    else if (Form1.rB == 2)
                    {
                        if (File.ReadAllText("high2.txt").Length == 0)
                            File.AppendAllText("high2.txt", score + "|" + PN);
                        else
                            File.AppendAllText("high2.txt", "\n" + score + "|" + PN);
                    }
                    else if (Form1.rB == 3)
                    {
                        if (File.ReadAllText("high3.txt").Length == 0)
                            File.AppendAllText("high3.txt", score + "|" + PN);
                        else
                            File.AppendAllText("high3.txt", "\n" + score + "|" + PN);
                    }

                }
                else
                {
                    label8.Text = Convert.ToString(score);
                    label7.Text = counter.ToString();
                    Random r = new Random();
                    pictureBox1.Location = new Point(r.Next(panel1.Width - pictureBox1.Width), r.Next(panel1.Height - pictureBox1.Height));
                    pictureBox2.Location= new Point(r.Next(panel1.Width - pictureBox2.Width), r.Next(panel1.Height - pictureBox2.Height));
                    pictureBox3.Location = new Point(r.Next(panel1.Width - pictureBox3.Width), r.Next(panel1.Height - pictureBox3.Height));
                    if (Form1.rB == 3) {
                        timer1.Interval = 500;
                        if (counter>=10 && counter<=40)  
                        {
                            //Change the background color of the panel to make it harder for the player only in "HARD" level
                            caseSwitch++;
                            
                            switch (caseSwitch)
                            {
                                case 1:
                                    panel1.BackColor = Color.Black;
                                    break;
                                case 2:
                                    panel1.BackColor = Color.Aqua;
                                    break;
                                case 3:
                                    panel1.BackColor = Color.Purple;
                                    break;
                                case 4:
                                    panel1.BackColor = Color.Transparent;
                                    break;
                            }
                            if (caseSwitch == 4) caseSwitch = 0;
                           
                        } 
                    }
                }
            }
                
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.URL = Environment.CurrentDirectory + "/" + "song2.mp3";
            player.controls.play();
            if (counter < 10)
            {
                counter++;
            }

            score += 10;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.URL = Environment.CurrentDirectory + "/" + "song2.mp3";
            player.controls.play();
            score -= 5;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.URL = Environment.CurrentDirectory + "/" + "song2.mp3";
            player.controls.play();
            score -= 10;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
