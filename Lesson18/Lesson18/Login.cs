using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson18
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            UserMethods.Login(loginUser.Text, loginPass.Text);

        }

        private void dontHaveAcount_Click(object sender, EventArgs e)
        {
            var rg = new Registration();
            rg.ShowDialog();
        }
    }
}
