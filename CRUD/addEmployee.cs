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
    public partial class addEmployee : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public addEmployee()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Please Fill up the blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {

                Random rnd = new Random();
                int acc_num = rnd.Next(1000, 9000);
                lvla.Text = acc_num.ToString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_employee VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + lvla.Text + "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("you successfully added an Employee", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();

                lvla.Text = "0";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Text = "";
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();

                this.Hide();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
