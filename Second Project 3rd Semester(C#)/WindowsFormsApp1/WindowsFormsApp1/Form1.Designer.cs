namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Remove_Box2 = new System.Windows.Forms.TextBox();
            this.Remove_Box3 = new System.Windows.Forms.TextBox();
            this.Remove_Box1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Music_button = new System.Windows.Forms.Button();
            this.SetImg_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.SetPhoto_pictureBox = new System.Windows.Forms.PictureBox();
            this.Apply_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetPhoto_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Remove_Box2);
            this.panel1.Controls.Add(this.Remove_Box3);
            this.panel1.Controls.Add(this.Remove_Box1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Music_button);
            this.panel1.Controls.Add(this.SetImg_button);
            this.panel1.Controls.Add(this.OK_button);
            this.panel1.Controls.Add(this.SetPhoto_pictureBox);
            this.panel1.Controls.Add(this.Apply_button);
            this.panel1.Controls.Add(this.Remove_button);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Search_comboBox);
            this.panel1.Controls.Add(this.FirstName_textBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Address_textBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LastName_textBox);
            this.panel1.Controls.Add(this.Email_textBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Phone_textBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 511);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(519, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 42;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove_Box2
            // 
            this.Remove_Box2.Location = new System.Drawing.Point(450, 431);
            this.Remove_Box2.Name = "Remove_Box2";
            this.Remove_Box2.Size = new System.Drawing.Size(100, 20);
            this.Remove_Box2.TabIndex = 41;
            this.Remove_Box2.Visible = false;
            // 
            // Remove_Box3
            // 
            this.Remove_Box3.Location = new System.Drawing.Point(450, 459);
            this.Remove_Box3.Name = "Remove_Box3";
            this.Remove_Box3.Size = new System.Drawing.Size(100, 20);
            this.Remove_Box3.TabIndex = 40;
            this.Remove_Box3.Visible = false;
            // 
            // Remove_Box1
            // 
            this.Remove_Box1.Location = new System.Drawing.Point(450, 405);
            this.Remove_Box1.Name = "Remove_Box1";
            this.Remove_Box1.Size = new System.Drawing.Size(100, 20);
            this.Remove_Box1.TabIndex = 39;
            this.Remove_Box1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(351, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(559, 330);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // Music_button
            // 
            this.Music_button.BackColor = System.Drawing.Color.Black;
            this.Music_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Music_button.ForeColor = System.Drawing.Color.White;
            this.Music_button.Location = new System.Drawing.Point(117, 218);
            this.Music_button.Name = "Music_button";
            this.Music_button.Size = new System.Drawing.Size(87, 29);
            this.Music_button.TabIndex = 36;
            this.Music_button.Text = "Choose ";
            this.Music_button.UseVisualStyleBackColor = false;
            this.Music_button.Click += new System.EventHandler(this.Music_button_Click);
            // 
            // SetImg_button
            // 
            this.SetImg_button.BackColor = System.Drawing.Color.Black;
            this.SetImg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SetImg_button.ForeColor = System.Drawing.Color.White;
            this.SetImg_button.Location = new System.Drawing.Point(220, 372);
            this.SetImg_button.Name = "SetImg_button";
            this.SetImg_button.Size = new System.Drawing.Size(87, 29);
            this.SetImg_button.TabIndex = 35;
            this.SetImg_button.Text = "Choose ";
            this.SetImg_button.UseVisualStyleBackColor = false;
            this.SetImg_button.Click += new System.EventHandler(this.SetImg_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.BackColor = System.Drawing.Color.Black;
            this.OK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OK_button.ForeColor = System.Drawing.Color.White;
            this.OK_button.Location = new System.Drawing.Point(556, 426);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(87, 29);
            this.OK_button.TabIndex = 32;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = false;
            this.OK_button.Visible = false;
            this.OK_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetPhoto_pictureBox
            // 
            this.SetPhoto_pictureBox.BackColor = System.Drawing.Color.White;
            this.SetPhoto_pictureBox.Location = new System.Drawing.Point(92, 261);
            this.SetPhoto_pictureBox.Name = "SetPhoto_pictureBox";
            this.SetPhoto_pictureBox.Size = new System.Drawing.Size(122, 140);
            this.SetPhoto_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SetPhoto_pictureBox.TabIndex = 31;
            this.SetPhoto_pictureBox.TabStop = false;
            // 
            // Apply_button
            // 
            this.Apply_button.BackColor = System.Drawing.Color.Black;
            this.Apply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Apply_button.ForeColor = System.Drawing.Color.White;
            this.Apply_button.Location = new System.Drawing.Point(242, 428);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(87, 29);
            this.Apply_button.TabIndex = 30;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = false;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.BackColor = System.Drawing.Color.Black;
            this.Remove_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Remove_button.ForeColor = System.Drawing.Color.White;
            this.Remove_button.Location = new System.Drawing.Point(351, 428);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(87, 29);
            this.Remove_button.TabIndex = 29;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = false;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.Black;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Edit_button.ForeColor = System.Drawing.Color.White;
            this.Edit_button.Location = new System.Drawing.Point(140, 428);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(87, 29);
            this.Edit_button.TabIndex = 28;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.Black;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(42, 428);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(87, 29);
            this.Add_button.TabIndex = 27;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(29, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Birthday";
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(351, 34);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(145, 26);
            this.Search_comboBox.TabIndex = 19;
            this.Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.Search_comboBox_SelectedIndexChanged);
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FirstName_textBox.Location = new System.Drawing.Point(116, 32);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(111, 22);
            this.FirstName_textBox.TabIndex = 18;
            this.FirstName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_textBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(28, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(28, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Music";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Photo";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Address_textBox.Location = new System.Drawing.Point(116, 188);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(111, 22);
            this.Address_textBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Address";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastName_textBox.Location = new System.Drawing.Point(116, 63);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(111, 22);
            this.LastName_textBox.TabIndex = 10;
            this.LastName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_textBox_KeyPress);
            // 
            // Email_textBox
            // 
            this.Email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Email_textBox.Location = new System.Drawing.Point(116, 157);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(111, 22);
            this.Email_textBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "E-mail";
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Phone_textBox.Location = new System.Drawing.Point(116, 123);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(111, 22);
            this.Phone_textBox.TabIndex = 7;
            this.Phone_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone Num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Details ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date and Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(126, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.database1DataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table1TableAdapter = this.table1TableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetPhoto_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.PictureBox SetPhoto_pictureBox;
        private System.Windows.Forms.Button Apply_button;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Search_comboBox;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SetImg_button;
        private System.Windows.Forms.Button Music_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Add_button;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Database1DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Remove_Box2;
        private System.Windows.Forms.TextBox Remove_Box3;
        private System.Windows.Forms.TextBox Remove_Box1;
        private System.Windows.Forms.Button button1;
    }
}

