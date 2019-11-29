namespace CRUD
{
    partial class account
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            this.refreshbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.tblloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_posDataSet = new CRUD.db_posDataSet();
            this.tbl_loginTableAdapter = new CRUD.db_posDataSetTableAdapters.tbl_loginTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.privileges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt5 = new System.Windows.Forms.ComboBox();
            this.txt4 = new System.Windows.Forms.ComboBox();
            this.txt3 = new System.Windows.Forms.ComboBox();
            this.txt9 = new System.Windows.Forms.ComboBox();
            this.lbl_act = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.ComboBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Menubtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvla = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_posDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshbtn
            // 
            this.refreshbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(775, 80);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(98, 42);
            this.refreshbtn.TabIndex = 2;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(242, 388);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(98, 42);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // tblloginBindingSource
            // 
            this.tblloginBindingSource.DataMember = "tbl_login";
            this.tblloginBindingSource.DataSource = this.db_posDataSet;
            // 
            // db_posDataSet
            // 
            this.db_posDataSet.DataSetName = "db_posDataSet";
            this.db_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_loginTableAdapter
            // 
            this.tbl_loginTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_time.Location = new System.Drawing.Point(771, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(66, 24);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.username,
            this.password,
            this.first_name,
            this.last_name,
            this.birthdate,
            this.privileges,
            this.activated,
            this.date_created});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(388, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(593, 383);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 81;
            // 
            // password
            // 
            this.password.Text = "Password";
            this.password.Width = 97;
            // 
            // first_name
            // 
            this.first_name.Text = "First Name";
            this.first_name.Width = 98;
            // 
            // last_name
            // 
            this.last_name.Text = "Last Name";
            this.last_name.Width = 95;
            // 
            // birthdate
            // 
            this.birthdate.Text = "Birthdate";
            this.birthdate.Width = 109;
            // 
            // privileges
            // 
            this.privileges.Text = "Privileges";
            this.privileges.Width = 78;
            // 
            // activated
            // 
            this.activated.Text = "Activated";
            this.activated.Width = 72;
            // 
            // date_created
            // 
            this.date_created.Text = "Date Created";
            this.date_created.Width = 110;
            // 
            // txt5
            // 
            this.txt5.FormattingEnabled = true;
            this.txt5.Items.AddRange(new object[] {
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
            this.txt5.Location = new System.Drawing.Point(218, 177);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(51, 21);
            this.txt5.TabIndex = 42;
            // 
            // txt4
            // 
            this.txt4.FormattingEnabled = true;
            this.txt4.Items.AddRange(new object[] {
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
            this.txt4.Location = new System.Drawing.Point(173, 177);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(39, 21);
            this.txt4.TabIndex = 41;
            // 
            // txt3
            // 
            this.txt3.FormattingEnabled = true;
            this.txt3.Items.AddRange(new object[] {
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
            this.txt3.Location = new System.Drawing.Point(108, 177);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(59, 21);
            this.txt3.TabIndex = 40;
            // 
            // txt9
            // 
            this.txt9.FormattingEnabled = true;
            this.txt9.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.txt9.Location = new System.Drawing.Point(108, 309);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(161, 21);
            this.txt9.TabIndex = 39;
            // 
            // lbl_act
            // 
            this.lbl_act.AutoSize = true;
            this.lbl_act.Location = new System.Drawing.Point(31, 312);
            this.lbl_act.Name = "lbl_act";
            this.lbl_act.Size = new System.Drawing.Size(46, 13);
            this.lbl_act.TabIndex = 38;
            this.lbl_act.Text = "Activate";
            // 
            // txt8
            // 
            this.txt8.FormattingEnabled = true;
            this.txt8.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.txt8.Location = new System.Drawing.Point(108, 275);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(161, 21);
            this.txt8.TabIndex = 37;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(108, 239);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(161, 20);
            this.txt7.TabIndex = 35;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(108, 208);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(161, 20);
            this.txt6.TabIndex = 34;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(108, 127);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(161, 20);
            this.txt2.TabIndex = 33;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(108, 93);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(161, 20);
            this.txt1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Privileges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Information";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 44;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menubtn
            // 
            this.Menubtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menubtn.Location = new System.Drawing.Point(883, 80);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(98, 42);
            this.Menubtn.TabIndex = 45;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 42);
            this.button2.TabIndex = 46;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvla
            // 
            this.lvla.AutoSize = true;
            this.lvla.Location = new System.Drawing.Point(218, 50);
            this.lvla.Name = "lvla";
            this.lvla.Size = new System.Drawing.Size(13, 13);
            this.lvla.TabIndex = 47;
            this.lvla.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 523);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lvla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.lbl_act);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.refreshbtn);
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_posDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button deletebtn;
        private db_posDataSet db_posDataSet;
        private System.Windows.Forms.BindingSource tblloginBindingSource;
        private db_posDataSetTableAdapters.tbl_loginTableAdapter tbl_loginTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader birthdate;
        private System.Windows.Forms.ColumnHeader privileges;
        private System.Windows.Forms.ColumnHeader activated;
        private System.Windows.Forms.ColumnHeader date_created;
        private System.Windows.Forms.ComboBox txt5;
        private System.Windows.Forms.ComboBox txt4;
        private System.Windows.Forms.ComboBox txt3;
        private System.Windows.Forms.ComboBox txt9;
        private System.Windows.Forms.Label lbl_act;
        private System.Windows.Forms.ComboBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lvla;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}