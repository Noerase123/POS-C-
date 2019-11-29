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
    public partial class StockList : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public StockList()
        {
            InitializeComponent();
            timer1.Start();
            stocklist();
        }

        public void stocklist()
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from tbl_stocks", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["unit"].ToString());
                listitem.SubItems.Add(dr["brand"].ToString());
                listitem.SubItems.Add(dr["price"].ToString());
                listitem.SubItems.Add(dr["description"].ToString());
                listitem.SubItems.Add(dr["date_created"].ToString());
                listitem.SubItems.Add(dr["account"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                pname.Text = item.SubItems[1].Text;
                punit.Text = item.SubItems[2].Text;
                pbrand.Text = item.SubItems[3].Text;
                pprice.Text = item.SubItems[4].Text;
                pdesc.Text = item.SubItems[5].Text;
                lvla.Text = item.SubItems[7].Text;


            }
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = "TODAY : " + datetime.ToString(("h:mm:ss tt"));
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (pname.Text == "" || punit.Text == "" || pbrand.Text == "" || pprice.Text == "" || pdesc.Text == "")
            {
                MessageBox.Show("Please Fill up the blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            else
            {
                Random rnd = new Random();
                int acc_num = rnd.Next(100000, 900000);
                lvla.Text = acc_num.ToString();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_stocks VALUES ('" + pname.Text + "','" + punit.Text + "','" + pbrand.Text + "','" + pprice.Text + "','" + pdesc.Text + "','" + lvla.Text + "','" + dateTimePicker1.Value + "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("you successfully added a Product", "Stock Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();

                lvla.Text = "0";
                pname.Clear();
                punit.Clear();
                pbrand.Clear();
                pprice.Clear();
                pdesc.Clear();

                stocklist();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (pname.Text == "" || punit.Text == "" || pbrand.Text == "" || pprice.Text == "" || pdesc.Text == "")
            {
                MessageBox.Show("Please Fill up the blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lvla.Text = "0";
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_stocks SET name = '" + pname.Text + "',unit = '" + punit.Text + "',brand = '" + pbrand.Text + "',price = '" + pprice.Text + "',description = '" + pdesc.Text + "',date_created = '" + dateTimePicker1.Value + "' WHERE account = '" + lvla.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("you successfully updated a Product", "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lvla.Text = "0";
                pname.Clear();
                punit.Clear();
                pbrand.Clear();
                pprice.Clear();
                pdesc.Clear();

                stocklist();
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
                SqlCommand cmd = new SqlCommand("delete tbl_stocks where account = '" + lvla.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Deleted Successfully!");
                conn.Close();

                lvla.Text = "0";
                pname.Clear();
                punit.Clear();
                pbrand.Clear();
                pprice.Clear();
                pdesc.Clear();


                stocklist();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvla.Text = "0";
            pname.Clear();
            punit.Clear();
            pbrand.Clear();
            pprice.Clear();
            pdesc.Clear();


            stocklist();
        }

        
    }
}
