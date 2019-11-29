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
    public partial class addStock : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password=12345678");

        public addStock()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                int acc_num = rnd.Next(1000, 9000);
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

                this.Hide();
            }
        }
    }
}
