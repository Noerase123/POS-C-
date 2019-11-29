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
    public partial class account : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public account()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void employeelist()
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from tbl_login", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["username"].ToString());
                listitem.SubItems.Add(dr["password"].ToString());
                listitem.SubItems.Add(dr["first_name"].ToString());
                listitem.SubItems.Add(dr["last_name"].ToString());
                listitem.SubItems.Add(dr["birthdate"].ToString());
                listitem.SubItems.Add(dr["privileges"].ToString());
                listitem.SubItems.Add(dr["activated"].ToString());
                listitem.SubItems.Add(dr["date_created"].ToString());
                listitem.SubItems.Add(dr["account"].ToString());
                listitem.SubItems.Add(dr["birthmonth"].ToString());
                listitem.SubItems.Add(dr["birthday"].ToString());
                listitem.SubItems.Add(dr["birthyear"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_posDataSet.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.db_posDataSet.tbl_login);

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            employeelist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = "TODAY : " + datetime.ToString(("h:mm:ss tt"));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txt6.Text = item.SubItems[1].Text;
                txt7.Text = item.SubItems[2].Text;

                txt3.Text = item.SubItems[10].Text;
                txt4.Text = item.SubItems[11].Text;
                txt5.Text = item.SubItems[12].Text;

                txt1.Text = item.SubItems[3].Text;
                txt2.Text = item.SubItems[4].Text;
                
                txt8.Text = item.SubItems[6].Text;
                txt9.Text = item.SubItems[7].Text;
                lvla.Text = item.SubItems[9].Text;

            }
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "" || txt6.Text == "" || txt7.Text == "" || txt8.Text == "" || txt9.Text == "")
            {
                MessageBox.Show("Please fill up the blanks");

            }
            else
            {
                Random rnd = new Random();
                int acc_num = rnd.Next(1000, 9000);
                lvla.Text = acc_num.ToString();

                string month = txt3.Text;
                string date = txt4.Text;
                string year = txt5.Text;

                string datetime = month.ToString() + "/" + date.ToString() + "/" + year.ToString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_login VALUES ('" + txt6.Text + "','" + txt7.Text + "','" + txt1.Text + "','" + txt2.Text + "','" + datetime.ToString() + "','" + txt8.Text + "','" + txt9.Text + "','" + dateTimePicker1.Value + "','" + lvla.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Your account is successfully registered as " + txt8.Text, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                conn.Close();
                employeelist();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "" || txt6.Text == "" || txt7.Text == "" || txt8.Text == "" || txt9.Text == "")
            {
                MessageBox.Show("Please Fill up the blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lvla.Text = "0";
            }
            else
            {
                string month = txt3.Text;
                string day = txt4.Text;
                string year = txt5.Text;

                string birthdate = month.ToString() + "/" + day.ToString() + "/" + year.ToString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_login SET username = '" + txt6.Text + "',password = '" + txt7.Text + "',first_name = '" + txt1.Text + "',last_name = '" + txt2.Text + "',birthdate = '" + birthdate.ToString() +"',privileges = '" + txt8.Text + "',activated = '" + txt9.Text + "',date_created = '" + dateTimePicker1.Value + "',birthmonth = '" + txt3.Text + "',birthday = '" + txt4.Text + "',birthyear = '" + txt5.Text + "' WHERE account = '" + lvla.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("you successfully updated an Employee", "Employee Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lvla.Text = "0";
                txt1.Clear();
                txt2.Clear();
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                txt6.Clear();
                txt7.Clear();
                txt8.Text = "";
                txt9.Text = "";

                employeelist();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (lvla.Text == "0")
            {
                MessageBox.Show("Select account number");

            }
            else
            {



                conn.Open();
                SqlCommand cmd = new SqlCommand("delete tbl_login where account = '" + lvla.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Deleted Successfully!");
                conn.Close();

                lvla.Text = "0";
                txt1.Clear();
                txt2.Clear();
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                txt6.Clear();
                txt7.Clear();
                txt8.Text = "";
                txt9.Text = "";


                employeelist();
            }
        }
    }
}
