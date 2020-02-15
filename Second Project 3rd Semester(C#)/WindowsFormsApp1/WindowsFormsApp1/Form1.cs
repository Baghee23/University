using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        
        private string selected;
        String cID;
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
        OleDbConnection connection;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        //mcfile string is used to store the mp3 file path and then save it in db 
        //photofile string is used to store the photo file path and then save it in db 
        private string mcfile;
        private string photofile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            connection = new OleDbConnection(connectionString);
            //Fill the combobox with every contact saved in the db and display their names #
            connection.Open();
            String query = "Select * from Table1";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                Search_comboBox.Items.Add(reader.GetString(1) + " " + reader.GetString(2));
                
            }
         
            connection.Close();
            //#End of filling process 
            //Function to display if someone from the saved contacts has or hasn't birthday today 
            TodayIsBirthDay();
           //Display the current date and time 
            label3.Text = DateTime.Now.ToString();
            
 
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            //Initialize a boolean var f2 in order to check if the given name,lastname and phone(contact) exists in the address book   
            bool f2 = true;
            //Initialize a boolean var f in order to check the inputs of the user   
            bool f = true;
            String name = FirstName_textBox.Text;
            String lastname = LastName_textBox.Text;
            String birthday = dateTimePicker1.Text;
            String phone = Convert.ToString(Phone_textBox.Text);
            String email = Email_textBox.Text;
            String address = Address_textBox.Text;
            //Boolean isEmail checks if the given Email_textBox text is in an email
            bool isEmail = Regex.IsMatch(Email_textBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Check if the phone input has 10 digits 
            if (Phone_textBox.Text.Length < 10 || Phone_textBox.Text.Length > 10)
            {
                f = false;
                MessageBox.Show("Phone numbers require 10 digits");

            }
            //Check if all inputs are properly field 
            if (FirstName_textBox.Text.Length < 1 || LastName_textBox.Text.Length < 1 || Email_textBox.Text.Length < 4 || Address_textBox.Text.Length < 1 || mcfile == String.Empty || photofile == String.Empty || isEmail==false)
            {

                f = false;
                MessageBox.Show("Please fill all the fields correctly!");
            }
            //If the contact already exists don't let the user add it again
            if (f2 == true)
            {
                connection.Open();
                String query = "Select * from Table1";

                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                    if (name == reader.GetString(1) && lastname == reader.GetString(2) && phone == reader.GetString(7))
                    {
                        f2 = false;
                    }

                }
                connection.Close();

            }
            //Show a message if the contact already exists 
            if (f2 == false)
            {
                MessageBox.Show("Already exists in the addressbook");
            }
            //Add the contact in the database 
            if (f2 == true)
            {
                
                if (f == true)
                {

                    connection.Open();
                    String query = "Insert into Table1(FirstName,LastName,Birthday,Phone,Email,Address,Music,Photo) " +
                        "values ('" + name + "','" + lastname + "','" + birthday + "','" + phone + "','" + email + "','" + address + "','" + mcfile + "','" + photofile + "')";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    int count = command.ExecuteNonQuery();
                    connection.Close();
                    //Inform the user that the contact was added
                    if (count == 1) MessageBox.Show("Contact added successfully");
                    //Display every contact in the richtextbox 
                    button1.PerformClick();

                }
            }
            //Clear all the boxes 
            ClearBoxes();
        }




        private void Remove_button_Click(object sender, EventArgs e)
        {
            //Show all the fields to let the user remove a contact 
            Remove_Box1.Show();
            Remove_Box2.Show();
            Remove_Box3.Show();
            OK_button.Show();
            ClearBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_button.Enabled = true;
            //Ask the user again 
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String name = Remove_Box1.Text;
                String name2 = Remove_Box2.Text;
                String phone = Remove_Box3.Text;
                
                connection.Open();
                String query = "Delete from Table1 " +
                    "Where FirstName=? AND LastName=? AND Phone=?";
                    
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("FirstName", name);
                command.Parameters.AddWithValue("LastName", name2);
                command.Parameters.AddWithValue("Phone", phone);
                int count = command.ExecuteNonQuery();
                connection.Close();
                if (count == 1)
                {
                    Remove_Box1.Hide();
                    Remove_Box2.Hide();
                    Remove_Box3.Hide();
                    OK_button.Hide();
                    MessageBox.Show("The contact was successfully removed from your Address Book!");
                    
                    
                }
                else
                {
                    Remove_Box1.Hide();
                    Remove_Box2.Hide();
                    Remove_Box3.Hide();
                    OK_button.Hide();
                    MessageBox.Show("There's no such contact with that Name and Phone number in your Address Book");
                }
                button1.PerformClick();
            }
            
            ClearBoxes();

        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            bool f = true;
            String name = FirstName_textBox.Text;
            String lastname = LastName_textBox.Text;
            String birthday = dateTimePicker1.Text;
            String phone = Convert.ToString(Phone_textBox.Text);
            String email = Email_textBox.Text;
            String address = Address_textBox.Text;
            bool isEmail = Regex.IsMatch(Email_textBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (Phone_textBox.Text.Length < 10 || Phone_textBox.Text.Length > 10)
            {
                f = false;
                MessageBox.Show("Phone numbers require 10 digits");


            }
            if (FirstName_textBox.Text.Length < 1 || LastName_textBox.Text.Length < 1 || Email_textBox.Text.Length < 4 || Address_textBox.Text.Length < 1 || mcfile == String.Empty || photofile == String.Empty || isEmail == false)
            {
                f = false;
                MessageBox.Show("Please fill all the fields correctly!");
            }
            
            if (f == true)
            {
                //Edit the selected contact's info 
                Add_button.Enabled = true;
                connection.Open();
                String query = "update Table1 set FirstName='" + name + "' ,LastName='" + lastname + "' ,Birthday='" + birthday + "' ,Phone='" + phone + "' ,Email='" + email + "' ,Address='" + address + "' ,Music='" + mcfile + "' ,Photo='" + photofile + "' where ID=" + cID + "";
                OleDbCommand command = new OleDbCommand(query, connection);
                int count = command.ExecuteNonQuery();
                connection.Close();
                if (count == 1) MessageBox.Show("Contact edited successfully");
                button1.PerformClick();
            }
            
            
        }

        private void SetImg_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                SetPhoto_pictureBox.ImageLocation = Open.FileName;
                //get the path of the photo
                photofile = Open.FileName;
            } 
        }
       

        private void Music_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Video (.wmv)|*.wmv|Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            //get the path of the audio file 
            mcfile = openFileDialog1.FileName;
            
        }



        private void Edit_button_Click(object sender, EventArgs e)
        {
            Add_button.Enabled = false;
            Search_comboBox.Focus();
            Search_comboBox.Items.Clear();
            connection.Open();
            String query = "Select * from Table1";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                Search_comboBox.Items.Add(reader.GetString(1) + " " + reader.GetString(2));

            }
            connection.Close();


        }
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            //Show all the contacts in the Richtextbox 
            ClearBoxes();
            connection.Open();

            String query = "Select * from Table1";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            StringBuilder builder = new StringBuilder();
            while (reader.Read())
            {
                builder.AppendLine(reader.GetString(1) + "/" + reader.GetString(2) + "/" + reader.GetString(8) + "/" + reader.GetString(7) + "/" + reader.GetString(3) + "/" + reader.GetString(4));
                
            }

            connection.Close();
            richTextBox1.Clear();
            richTextBox1.AppendText(builder.ToString());
        }

        private void Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = Search_comboBox.GetItemText(Search_comboBox.SelectedItem);
            connection.Open();

            String query = "Select * from Table1";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            //Display all the selected contact's info in the fields 
            while (reader.Read())
            {
                if (selected == reader.GetString(1) + " " + reader.GetString(2))
                {
                    cID=reader["ID"].ToString();
                    FirstName_textBox.Text = reader.GetString(1);
                    LastName_textBox.Text = reader.GetString(2);
                    dateTimePicker1.Text = reader.GetString(8);
                    Phone_textBox.Text = reader.GetString(7);
                    Email_textBox.Text = reader.GetString(3);
                    Address_textBox.Text = reader.GetString(4);
                    mcfile = reader.GetString(5);
                    photofile = reader.GetString(6);
                    SetPhoto_pictureBox.Image = Image.FromFile(@photofile);
                    
                }
            }
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
        
        

        private void Phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                Char chr = e.KeyChar;
                if (!Char.IsDigit(chr) && chr != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("Please enter a valid input");
                }
                
        }

        private void FirstName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar));
        }

        private void LastName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar));
        }

        private void TodayIsBirthDay()
        {
            //Check if somebody has birthday today,display the name and lastname and play his/her song 
            connection.Open();


            String query = "Select * from Table1";


            OleDbCommand command = new OleDbCommand(query, connection);


            OleDbDataReader reader = command.ExecuteReader();


            StringBuilder builder = new StringBuilder();

            string birthdayText = "Nobody has birthday today!";


            while (reader.Read())
            {

                //DATE TODAY
                var today = dateTimePicker1.Text.Split(',');
                string compareVar =  today[1];
                //BIRTHDATE
                string birthDate;
                
                birthDate = reader.GetString(8);
                var split = birthDate.Split(',');

                birthDate =  split[1];
                
                if (birthDate == compareVar)
                {
                    //RINGTONE & MESSAGE 
                    player.URL = reader.GetString(5);
                    player.controls.play();
                    birthdayText = "Its " + reader.GetString(1) + " " + reader.GetString(2) + " birthday wish him/her happy birthday !!";
                    
                }

            }
            connection.Close();
            MessageBox.Show(birthdayText, "Birthday");
        }
        private void ClearBoxes()
        {
            //Clear all the boxes of the form
            Search_comboBox.Items.Clear();
            connection.Open();
            String query = "Select * from Table1";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                Search_comboBox.Items.Add(reader.GetString(1) + " " + reader.GetString(2));

            }
            connection.Close();
            FirstName_textBox.Text = String.Empty;
            LastName_textBox.Text = String.Empty;
            Phone_textBox.Text = String.Empty;
            Email_textBox.Text = String.Empty;
            Address_textBox.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;

            SetPhoto_pictureBox.Image = null;

            mcfile = String.Empty;
            photofile = String.Empty;
            Remove_Box1.Text = String.Empty;
            Remove_Box2.Text = String.Empty;
            Remove_Box3.Text = String.Empty;
        }

    }
}
