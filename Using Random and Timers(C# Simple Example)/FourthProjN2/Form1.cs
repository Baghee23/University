using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourthProjN2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        Random r;
        private int x;
        private int y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Pen(Color.Red);
            g = this.CreateGraphics();
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            x = e.X;
            y = e.Y;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(-100, 100);
            int x1 = x + num;
            int z = 10000 - (num * num);
            double temp1 = Math.Round(Math.Sqrt(z), 2);
            int y1 = Convert.ToInt32(temp1);
            int r_sym = r.Next(0, 2);
            if (r_sym == 0)
            {
                y1 = y - y1;
            }
            else
            {
                y1 = y1 + y;
            }
            g.DrawLine(p, x, y, x1, y1);
        }
    }
}
