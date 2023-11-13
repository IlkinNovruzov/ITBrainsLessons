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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

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

        private void dataGridView_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.Open();
                string query = $"select * from Rooms";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_room.DataSource = dt;
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");

        private void button_add_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string status = radioButton_free.Checked ? "true" : "false";
                int typeId = Convert.ToInt32(comboBox_roomType.SelectedValue);
                string query = $"insert into Rooms values({typeId},'{status}')";
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
    }
}
