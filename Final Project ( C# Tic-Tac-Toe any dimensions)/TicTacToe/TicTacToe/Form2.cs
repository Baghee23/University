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

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2(int rb)
        {
            InitializeComponent();
        }
        ComputerEnemy obj0 = new ComputerEnemy();
        private bool f = true;
        List<Button> buttons = new List<Button>();
        private int c;
        private int dim;
        private int w;
        private bool play = false;
        int wins;
        int ties;
        int defeats;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dimTextBox.Text == "" || dimTextBox.Text == "Just 1 odd" || CheckOdd(f) == false)
            {
                MessageBox.Show("Please enter just one odd number and greater than 3(e.g. 5) to proceed!");
            }
            else
            {
                button1.Hide();
                button1.Enabled = false;
                this.Cursor = Cursors.Hand;
                dim = Convert.ToInt32(dimTextBox.Text);
                generateButtons(dim);
                button2.Show();
                


            }

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "CLICK ME !!!";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "SELECT DIMENSIONS!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dimTextBox.Show();
        }

        private void dimTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dimTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(dimTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                dimTextBox.Text = "";
            }
        }

        private void dimTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            dimTextBox.Text = "";
        }
        private bool CheckOdd(bool f)
        {

            if (Convert.ToInt32(dimTextBox.Text) % 2 == 0 || Convert.ToInt32(dimTextBox.Text) <= 3)
            {
                f = false;
            }
            else
            {
                f = true;
            }
            return f;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
        protected void genBtn_Click(object sender, EventArgs e)
        {

            var buttonSndr = (Button)sender;
            if (buttonSndr.Text != "X" && buttonSndr.Text != "O" && play == false)
            {
                buttonSndr.Font = new Font("Microsoft Sans Serif", 10);
                if (f == true)
                {

                    buttonSndr.BackColor = Color.Black;
                    buttonSndr.ForeColor = Color.Gold;
                    buttonSndr.Text = "X";
                    if (Form1.rb == 1)
                    {
                        TurnLbl.Text = "Comp's Turn";

                        c += 1;
                        if (c == buttons.Count)
                        {
                            f = false;
                        }
                        else
                        {
                            obj0.CompAutoPlay(buttons);
                            TurnLbl.Text = "Player's 1 Turn";
                            f = true;
                        }


                    }

                    else
                    {
                        TurnLbl.Text = "Player's 2 Turn";
                        f = false;
                    }
                    Game(c, dim, w);

                }
                else
                {
                    
                    buttonSndr.BackColor = Color.White;
                    buttonSndr.ForeColor = Color.Red;
                    buttonSndr.Text = "O";
                    TurnLbl.Text = "Player's 1 Turn";
                    f = true;
                    Game(c, dim, w);
                    
                }
                c += 1;
                if (Form1.rb == 2 && c==buttons.Count)
                {
                    Game(c, dim, w);
                }

            }
            else
            {
                if (play == true)
                {
                    MessageBox.Show("The result has been decided!");
                }
                else
                {
                    MessageBox.Show("This tile is already taken!");
                }

            }
            
        }
        protected void Game(int c, int dim, int w)
        {
            w = buttons.Count;

            int k5 = 0;
            int k6 = 0;
            int k7 = 0;
            int k8 = 0;
            string[,] a = new string[dim, dim];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    a[i, j] = buttons[w - 1].Text;
                    w -= 1;

                }
            }
            for (int i = 0; i < dim; i++)
            {
                int k1 = 0;
                int k2 = 0;
                int k3 = 0;
                int k4 = 0;
                for (int j = 0; j < dim; j++)
                {
                    if (a[i, j] == "X")
                    {
                        k2 = 0;
                        k1 += 1;
                    }
                    else if (a[i, j] == "O")
                    {
                        k1 = 0;
                        k2 += 1;
                    }
                }
                if (k1 == dim)
                {

                    MessageBox.Show("Player 1 wins!");
                    wins += 1;
                    if (Form1.rb == 1)
                    {
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;

                }
                else if (k2 == dim)
                {
                    defeats += 1;
                    if (Form1.rb == 2)
                    {
                        MessageBox.Show("Player 2 wins!");
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");

                    }
                    else
                    {
                        MessageBox.Show("Computer wins!");
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;
                }

                for (int j = 0; j < dim; j++)
                {
                    if (a[j, i] == "X")
                    {
                        k4 = 0;
                        k3 += 1;
                    }
                    else if (a[j, i] == "O")
                    {
                        k3 = 0;
                        k4 += 1;
                    }
                }
                if (k3 == dim)
                {
                    MessageBox.Show("Player 1 wins!");
                    wins += 1;
                    if (Form1.rb == 1)
                    {
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;

                }
                else if (k4 == dim)
                {
                    defeats += 1;
                    if (Form1.rb == 2)
                    {
                        MessageBox.Show("Player 2 wins!");
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        MessageBox.Show("Computer wins!");
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;
                }
                if (a[i, i] == "X")
                {
                    k6 = 0;
                    k5 += 1;
                }
                else if (a[i, i] == "O")
                {
                    k5 = 0;
                    k6 += 1;
                }
                if (k5 == dim)
                {
                    MessageBox.Show("Player 1 wins!");
                    wins += 1;
                    if (Form1.rb == 1)
                    {
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;

                }
                else if (k6 == dim)
                {
                    defeats += 1;
                    if (Form1.rb == 2)
                    {
                        MessageBox.Show("Player 2 wins!");
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        MessageBox.Show("Computer wins!");
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;
                }
                for (int j = 0; j < dim; j++)
                {
                    if (i == dim - j - 1)
                    {
                        if (a[j, dim - j - 1] == "X")
                        {
                            k8 = 0;
                            k7 += 1;
                        }
                        else if (a[j, dim - j - 1] == "O")
                        {
                            k7 = 0;
                            k8 += 1;
                        }
                    }

                }

                if (k7 == dim)
                {
                    MessageBox.Show("Player 1 wins!");
                    wins += 1;
                    if (Form1.rb == 1)
                    {
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;

                }
                else if (k8 == dim)
                {
                    defeats += 1;
                    if (Form1.rb == 2)
                    {
                        MessageBox.Show("Player 2 wins!");
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        MessageBox.Show("Computer wins!");
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    play = true;
                    break;
                }



            }

            if (c == buttons.Count)
            {
                if (play == false)
                {
                    MessageBox.Show("The game has finished and the result is a tie!");
                    ties += 1;
                    if (Form1.rb == 1)
                    {
                        File.WriteAllText("StatsAgainstComp.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                    else
                    {
                        File.WriteAllText("StatsAgainstPlayer.txt", wins + "|" + ties + "|" + defeats + "\n");
                    }
                }
            }
        }
        private void generateButtons(int dim)
        {
            Point newLoc = new Point(210, 60);
            int x = 210;
            int y = 0;
            c = 0;


            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(30, 30);
                    b.Location = newLoc;
                    newLoc.Offset(0, b.Height + 5);
                    b.Click += new EventHandler(genBtn_Click);
                    buttons.Add(b);
                    Controls.Add(b);
                    y = b.Height + 5;
                }
                x += 35;
                newLoc = new Point(x, y + 25);
            }
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Hide();
            string[] score = File.ReadAllText("StatsAgainstPlayer.txt").Split(new string[] { "\n" }, StringSplitOptions.None);
            string[] score2 = File.ReadAllText("StatsAgainstComp.txt").Split(new string[] { "\n" }, StringSplitOptions.None);
            
            if (Form1.rb == 1)
            {
                string[] divide = score2[0].Split(new string[] { "|" }, StringSplitOptions.None);
                wins = Int32.Parse(divide[0]);
                ties = Int32.Parse(divide[1]);
                defeats = Int32.Parse(divide[2]);
            }
            else
            {
                string[] divide = score[0].Split(new string[] { "|" }, StringSplitOptions.None);
                wins = Int32.Parse(divide[0]);
                ties = Int32.Parse(divide[1]);
                defeats = Int32.Parse(divide[2]);
            }
            
        }
        private void R()
        {
                Form2 pl = new Form2(Form1.rb);
                pl.Show();
                this.Dispose(false);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                R();
            }
            else
            {
                if (MessageBox.Show("Your current progress will be deleted", "Confirm your choice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    R();
                }
            }
        }
    }
}
