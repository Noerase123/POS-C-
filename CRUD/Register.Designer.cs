namespace CRUD
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.privileges_user = new System.Windows.Forms.ComboBox();
            this.date_created = new System.Windows.Forms.DateTimePicker();
            this.activated = new System.Windows.Forms.ComboBox();
            this.lbl_act = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lvla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Privileges";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Add Account";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(111, 67);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(161, 20);
            this.first_name.TabIndex = 8;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(111, 101);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(161, 20);
            this.last_name.TabIndex = 9;
            // 
            // reg_username
            // 
            this.reg_username.Location = new System.Drawing.Point(389, 67);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(152, 20);
            this.reg_username.TabIndex = 11;
            // 
            // reg_password
            // 
            this.reg_password.Location = new System.Drawing.Point(389, 98);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(152, 20);
            this.reg_password.TabIndex = 12;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(306, 214);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(102, 42);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // privileges_user
            // 
            this.privileges_user.FormattingEnabled = true;
            this.privileges_user.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.privileges_user.Location = new System.Drawing.Point(389, 134);
            this.privileges_user.Name = "privileges_user";
            this.privileges_user.Size = new System.Drawing.Size(152, 21);
            this.privileges_user.TabIndex = 15;
            // 
            // date_created
            // 
            this.date_created.Location = new System.Drawing.Point(385, 11);
            this.date_created.Name = "date_created";
            this.date_created.Size = new System.Drawing.Size(200, 20);
            this.date_created.TabIndex = 16;
            // 
            // activated
            // 
            this.activated.FormattingEnabled = true;
            this.activated.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.activated.Location = new System.Drawing.Point(389, 168);
            this.activated.Name = "activated";
            this.activated.Size = new System.Drawing.Size(152, 21);
            this.activated.TabIndex = 18;
            // 
            // lbl_act
            // 
            this.lbl_act.AutoSize = true;
            this.lbl_act.Location = new System.Drawing.Point(303, 171);
            this.lbl_act.Name = "lbl_act";
            this.lbl_act.Size = new System.Drawing.Size(46, 13);
            this.lbl_act.TabIndex = 17;
            this.lbl_act.Text = "Activate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox1.Location = new System.Drawing.Point(111, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox2.Location = new System.Drawing.Point(176, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(39, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.comboBox3.Location = new System.Drawing.Point(221, 151);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(51, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // lvla
            // 
            this.lvla.AutoSize = true;
            this.lvla.Location = new System.Drawing.Point(12, 17);
            this.lvla.Name = "lvla";
            this.lvla.Size = new System.Drawing.Size(13, 13);
            this.lvla.TabIndex = 25;
            this.lvla.Text = "0";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 301);
            this.Controls.Add(this.lvla);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.activated);
            this.Controls.Add(this.lbl_act);
            this.Controls.Add(this.date_created);
            this.Controls.Add(this.privileges_user);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ComboBox privileges_user;
        private System.Windows.Forms.DateTimePicker date_created;
        private System.Windows.Forms.ComboBox activated;
        private System.Windows.Forms.Label lbl_act;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lvla;
    }
}