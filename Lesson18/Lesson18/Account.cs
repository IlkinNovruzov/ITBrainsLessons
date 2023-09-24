using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson18
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var lg = new Login();
            lg.ShowDialog();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            var rg = new Registration();
            rg.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = UserMethods.GetUsers()[0];
            textBox1.Text = user.username;
        }
    }
}
