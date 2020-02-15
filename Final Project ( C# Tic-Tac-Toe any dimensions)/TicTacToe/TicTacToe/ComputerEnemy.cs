using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class ComputerEnemy
    {
        public void CompAutoPlay(List<Button> buttons1)
        {
            Random r = new Random();
            int n;
            do
            {
                n = r.Next(buttons1.Count);
            }
            while (!string.IsNullOrWhiteSpace(buttons1[n].Text));

            buttons1[n].BackColor = Color.AliceBlue;
            buttons1[n].ForeColor = Color.Black;
            buttons1[n].Text = "O";
        }
    }
}
