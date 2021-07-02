using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Tubes_Software_Construction_BEN_ID
{
    public partial class Profile : Form
    {
        private object inputUsername;
        private object inputEmail;
        private object inputPass;
        private object inputnamapengguna;
        private static object obj;

        public object JsonConvert { get; private set; }

        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

    }
}
