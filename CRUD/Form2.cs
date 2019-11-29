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
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=JOHNISAAC\\SQLEXPRESS;Initial Catalog=db_pos;User ID=sa;password = 12345678");
            
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for logging on!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void singleTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            single singleTable = new single();
            singleTable.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            //table_grid.Visible = true;
            SqlDataAdapter sa = new SqlDataAdapter("select * from data", conn);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //table_grid.DataSource = dt;
            conn.Close();
            
        }


        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = "TODAY : " + datetime.ToString(("h:mm:ss tt"));

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            greet_name.Text = login.SetValueForText1;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_login WHERE username = '" + greet_name.Text + "' ",conn);
            SqlDataReader dr = cmd.ExecuteReader();

            string name;
            name = greet_name.Text;

            DateTime datetime = DateTime.Now;

            if (datetime.Hour < 12)
            {
                greeting.Text = "Good morning, " + name;
            }
            else if (datetime.Hour < 17)
            {
                greeting.Text = "Good Afternoon, " + name;
            }
            else
            {
                greeting.Text = "Good Evening, " + name;
            }

            dr.Close();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //employee button
            this.Hide();
            employeeList emp = new employeeList();
            emp.Show();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            account acc = new account();
            acc.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            account acc = new account();
            acc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockList stock = new StockList();
            stock.Show();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEmployee emp = new addEmployee();
            emp.Show();
        }

        private void newStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStock sto = new addStock();
            sto.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction tra = new Transaction();
            tra.Show();

        }

        
    }
}
