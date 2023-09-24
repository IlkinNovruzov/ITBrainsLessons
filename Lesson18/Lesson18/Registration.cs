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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void haveacoount_Click(object sender, EventArgs e)
        {
            var lg = new Login();
            lg.ShowDialog();
        }

        private void buttonrg_Click(object sender, EventArgs e)
        {
            if (textBoxPass1.Text != textBoxPass2.Text)
            {
                UserMethods.Registration(textBoxUser.Text, textBoxPass1.Text);
            }
        }
    }
}
