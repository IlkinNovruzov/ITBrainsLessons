using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Hotel_Management_System
{
    public partial class GuestForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
        public GuestForm()
        {
            InitializeComponent();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_fName.Clear();
            textBox_lName.Clear();
            textBox_city.Clear();
        }



        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"insert into Customers values('{textBox_fName.Text}','{textBox_lName.Text}','{textBox_city.Text}')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save is succesfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex);
            }
            finally
            {
                con.Close();
            }


        }



        private void GuestForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"select * from Customers";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
