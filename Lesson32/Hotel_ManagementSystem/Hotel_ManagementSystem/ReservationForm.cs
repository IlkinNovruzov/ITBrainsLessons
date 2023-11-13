using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }



        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"select * from Reservations";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_reserv.DataSource = dt;
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
        //the guest id 32 does not exists in the guest table
        // so we need to prevent this problem , add a foreign key guest id of the reservation table
        //And Room no 101 is busy now , is not available
        // so we need to prevent this problem , date condition now let start
        // add new reservation room , that room is set busy
        // delete reservation room , so room is free
        // now add the foreign key for the guest 
        // delete a room also reservation room 
        // create a relationship RoomNo of room table and RoomNo of reservation
    }
}
