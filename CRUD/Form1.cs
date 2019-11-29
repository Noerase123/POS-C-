using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class login : Form
    {
        public static string SetValueForText1 = "";
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }


        int attempts = 5;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetValueForText1 = userName.Text;

            conn.Open();

            bool loginadmin = false;
            bool loginuser = false;

            string activated = ("Enabled").ToString();

            string sql = ("SELECT * from tbl_login where username= '" + userName.Text + "' and password = '" + userPassword.Text + "' AND activated = '" + activated + "'");
            SqlCommand da = new SqlCommand(sql, conn);

            SqlDataReader dt = da.ExecuteReader();

            while (dt.Read())
            {
                string privileges;
                privileges = dt["privileges"].ToString();

                if (privileges == "admin")
                {
                    loginadmin = true;
                }
                else if (privileges == "user")
                {
                    loginuser = true;
                }
            }
            dt.Close();
            conn.Close();

            if (activated != "Enabled")
            {
                MessageBox.Show("Your account has been " + activated);
                
            }
            else
            {

                if (loginadmin == true)
                {
                    MessageBox.Show("You're logging in as Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form2 menu = new Form2();
                    menu.Show();
                }
                else if (loginuser == true)
                {
                    MessageBox.Show("You're logging in as user", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Transaction menu = new Transaction();
                    menu.Show();
                }
                else
                {
                    attempts--;

                    MessageBox.Show("Sorry Try Again. \n\n you have " + attempts + " attempts remaining.","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    userName.Clear();
                    userPassword.Clear();

                    if (attempts == 0)
                    {
                        Application.Exit();
                    }

                }
            }

            
        }

        private void userRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
