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
    public partial class Transaction : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public Transaction()
        {
            InitializeComponent();
            timer1.Start();
            stocklist();
            cartlist();



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
                ListViewItem listitem = new ListViewItem(dr["name"].ToString());
                listitem.SubItems.Add(dr["price"].ToString());
                listitem.SubItems.Add(dr["description"].ToString());
                listitem.SubItems.Add(dr["account"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        public void cartlist()
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from tbl_cart", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            listView2.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["sname"].ToString());
                listitem.SubItems.Add(dr["sprice"].ToString());
                listitem.SubItems.Add(dr["quantity"].ToString());
                listitem.SubItems.Add(dr["description"].ToString());
                listitem.SubItems.Add(dr["tran_num"].ToString());

                listView2.Items.Add(listitem);
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];
                lblname.Text = item.SubItems[0].Text;
                lblprice.Text = item.SubItems[1].Text;
                qty.Text = item.SubItems[2].Text;
                lbldesc.Text = item.SubItems[3].Text;
                lvla.Text = item.SubItems[4].Text;


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                lblname.Text = item.SubItems[0].Text;
                lblprice.Text = item.SubItems[1].Text;
                lbldesc.Text = item.SubItems[2].Text;
                lvla.Text = item.SubItems[3].Text;


            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            if (Totaltxt.Text == "")
            {
                MessageBox.Show("hello");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select sum((sprice * quantity)) from tbl_cart", conn);
                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();

                Totaltxt.Text = reader[0].ToString();
                reader.Close();
                conn.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();

            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_cart ");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = "TODAY : " + datetime.ToString(("h:mm:ss tt"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quantity.Text == "" || lblname.Text == "" || lblprice.Text == "" || lbldesc.Text == "")
            {
                MessageBox.Show("Please Select Item \n or \n Please enter the amount of Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_cart VALUES ('" + lblname.Text + "','" + lblprice.Text + "','" + quantity.Text + "','" + lvla.Text + "','" + lbldesc.Text + "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                quantity.Text = "";
                lvla.Text = "";
                lblname.Text = "";
                lblprice.Text = "";
                lbldesc.Text = "";

                cartlist();


            }

            if (lvla.Text == lvla.Text)
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE tbl_cart SET quantity = '" + qty.Text + "' WHERE tran_num = '" + lvla.Text + "'");
                MessageBox.Show("updated");
                cmd2.Connection = conn;
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (lvla.Text == "")
            {
                MessageBox.Show("Please Select Item");

            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete tbl_cart where tran_num = '" + lvla.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                if (lvla.Text == lvla.Text)
                {

                    quantity.Text = "";
                    lvla.Text = "";
                    lblname.Text = "";
                    lblprice.Text = "";
                    lbldesc.Text = "";
                }

                cartlist();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //AMOUNT

            if (amount.Text == "")
            {
                MessageBox.Show("Please Enter amount of money");
                
            }
            else
            {
                
            }
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(amount.Text, "  ^ [0-9]"))
            {
                amount.Text = "";
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 0;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 1;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 2;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 3;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 4;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 5;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 6;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 7;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 8;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            quantity.Text = quantity.Text + 9;
        }

        private void Totaltxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Totaltxt_Click(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
