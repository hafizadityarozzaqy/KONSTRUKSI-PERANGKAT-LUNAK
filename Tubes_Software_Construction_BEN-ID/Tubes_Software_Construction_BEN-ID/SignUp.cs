using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_Software_Construction_BEN_ID
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parameter.email = txtemail.Text;
            this.Hide();
            Parameter.namalengkap = txtnamalengkap.Text;
            this.Hide();
            Parameter.uname = txtuname.Text;
            this.Hide();
            Parameter.pass = txtpass.Text;
            this.Hide();
            Info a = new Info();
            a.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
