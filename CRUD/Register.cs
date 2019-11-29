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
    public partial class Register : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        

        public Register()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_password.Text == "" || first_name.Text == "" || last_name.Text == "" || date_created.Text == "")
            {
                MessageBox.Show("Please fill up the blanks");

            }
            else
            {
                Random rnd = new Random();
                int acc_num = rnd.Next(1000, 9000);
                lvla.Text = acc_num.ToString();

                string month = comboBox1.Text;
                string date = comboBox2.Text;
                string year = comboBox3.Text;

                string datetime = month.ToString() + "/" + date.ToString() + "/" + year.ToString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_login VALUES ('" + reg_username.Text + "','" + reg_password.Text + "','" + first_name.Text + "','" + last_name.Text + "','" + datetime.ToString() + "','" + privileges_user.Text + "','" + activated.Text + "','" + date_created.Value + "','" + lvla.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Your account is successfully registered as " + privileges_user.Text, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                conn.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
