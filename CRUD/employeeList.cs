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
    public partial class employeeList : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public employeeList()
        {
            InitializeComponent();
            timer1.Start();
            
        }




        public void employeelist()
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from tbl_employee", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["emp_id"].ToString());
                listitem.SubItems.Add(dr["full_name"].ToString());
                listitem.SubItems.Add(dr["current_add"].ToString());
                listitem.SubItems.Add(dr["perm_add"].ToString());
                listitem.SubItems.Add(dr["phone_num"].ToString());
                listitem.SubItems.Add(dr["email"].ToString());
                listitem.SubItems.Add(dr["position"].ToString());
                listitem.SubItems.Add(dr["date_started"].ToString());
                listitem.SubItems.Add(dr["bg_check"].ToString());
                listitem.SubItems.Add(dr["last_employed"].ToString());
                listitem.SubItems.Add(dr["salary"].ToString());
                listitem.SubItems.Add(dr["long_last_employed"].ToString());
                listitem.SubItems.Add(dr["account"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;
                textBox3.Text = item.SubItems[3].Text;
                textBox4.Text = item.SubItems[4].Text;
                textBox5.Text = item.SubItems[5].Text;
                textBox6.Text = item.SubItems[6].Text;
                textBox7.Text = item.SubItems[7].Text;
                textBox8.Text = item.SubItems[8].Text;
                textBox9.Text = item.SubItems[9].Text;
                textBox10.Text = item.SubItems[10].Text;
                textBox11.Text = item.SubItems[11].Text;
                lvla.Text = item.SubItems[12].Text;


            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" )
            {
            MessageBox.Show("Please Fill up the blank","Warning",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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

            employeelist();
            }
        }

        

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = "TODAY : " + datetime.ToString(("h:mm:ss tt"));
        }

        private void employeeList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_posDataSet1.tbl_employee' table. You can move, or remove it, as needed.
            this.tbl_employeeTableAdapter.Fill(this.db_posDataSet1.tbl_employee);
            employeelist();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" )
            {
            MessageBox.Show("Please Fill up the blank","Warning",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            lvla.Text = "0";
            }
            else
            {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_employee SET full_name = '" + textBox1.Text + "',current_add = '" + textBox2.Text+ "',perm_add = '" + textBox3.Text + "',phone_num = '" + textBox4.Text + "',email = '" + textBox5.Text + "',position = '" + textBox6.Text + "',date_started = '" + dateTimePicker1.Value + "',bg_check = '" + textBox8.Text + "',last_employed = '" + textBox9.Text + "',salary = '" + textBox10.Text + "',long_last_employed = '" + textBox11.Text + "' WHERE account = '" + lvla.Text +"'");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("you successfully updated an Employee","Employee Updated",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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
                SqlCommand cmd = new SqlCommand("delete tbl_employee where account = '" + lvla.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Deleted Successfully!");
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


                employeelist();
            }
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }


        

        
    }
}
