//Made by a humanoid named as:Fotis Stavropoulos
//Planet:Unknown 
//Condition:Unknown
//Dimension:Unknown 
//Time:Too lazy to write unknown again even if I practically just did
//Date:24/10/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                //Checks input at the textBoxes  
                Regex regex = new Regex("^[a-zA-Z]+$");
                bool flag = true;
                bool hasOnlyAlpha = regex.IsMatch(textBox1.Text);
                bool hasOnlyBeta = regex.IsMatch(textBox2.Text);
                if (hasOnlyAlpha || textBox1.Text=="" || textBox1.Text== "Please enter a number.")
                {
                    flag = false;
                    textBox3.Text = "Please enter numbers!";
                }
                if (hasOnlyBeta || textBox2.Text == "" || textBox2.Text == "Please enter a number.")
                {
                    flag = false;
                    textBox3.Text = "Please enter numbers!";
                }
                //If input is correct then proceed with the calculation selected from the comboBox 
                if (flag==true)
                {
                    //Convert anything the user had written in the textBoxes to floats in order to do the calculation 
                    float text1 = float.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    float text2 = float.Parse(textBox2.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    string combo1 = comboBox1.Text;
                    //Execute the calculation for each option the user can select and convert the result to a string again in order
                    //to show it at the last textBox.
                    if (combo1 == "+")
                    {
                        textBox3.Text = Convert.ToString(text1 + text2);
                    }
                    else if (combo1 == "-")
                    {
                        textBox3.Text = Convert.ToString(text1 - text2);
                    }
                    else if (combo1 == "*")
                    {
                        textBox3.Text = Convert.ToString(text1 * text2);
                    }
                    else if (combo1 == "/")
                    {
                    //If the input=0 then show "You can't divide with 0!" because the calculation can't be executed
                        if (text2 == 0)
                        {
                            textBox3.Text = "You can't divide with 0!";
                        }
                        else
                        {
                            textBox3.Text = Convert.ToString(text1 / text2);
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
