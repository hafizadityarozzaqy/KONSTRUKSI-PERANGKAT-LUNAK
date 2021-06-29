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
            var userRegister = new parsing();
            object inputUsername = inputUsername;
            userRegister.namapengguna = inputnamapengguna.Text;
            userRegister.email = inputEmail.Text;
            object inputnotelp = null;
            userRegister.nomortelepon = inputnotelp.Text;

            string bacaData = File.ReadAllText("D:/Parsing.json");

            List<db_register> listJson = JsonConvert.DeserializeObject<List<db_register>>(bacaData);
            listJson.Add(userRegister);
            var data = JsonConvert.SerializeObject(listJson, Formatting.Indented);
            File.WriteAllText("D:/Parsing.json", data);
        }
    }
}
