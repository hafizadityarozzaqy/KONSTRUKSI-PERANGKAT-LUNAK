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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Tpassword.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tlogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = "fahmiab11";
            password = "password";

            if (Tusername.Text == "" || Tpassword.Text == "")
            {
                MessageBox.Show("Mohon isikan username dan password terlebih dahulu!");
            }
            else
            {
                if (Tusername.Text == username && Tpassword.Text == password)
                {
                    MessageBox.Show("Login Berhasil!");
                    Tuser.Visible = false;
                    Tpass.Visible = false;
                    Tusername.Visible = false;
                    Tpassword.Visible = false;
                    new Menu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username dan password yang Anda masukkan salah!");
                }
            }
        }

        private void Tsignup_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void Tusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tlihat_CheckedChanged(object sender, EventArgs e)
        {
            if (Tlihat.Checked)
            {
                Tpassword.UseSystemPasswordChar = false;
            }
            else if (Tlihat.Checked)
            {
                Tpassword.UseSystemPasswordChar = true;
            }
        }

        private void Tkeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
