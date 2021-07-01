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
using Newtonsoft.Json;

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
            var userRegister = new parsing();
            object inputUsername = inputUsername;
            userRegister.namapengguna = inputnamapengguna.Text;
            userRegister.email = inputEmail.Text;
            object inputnotelp = null;
            userRegister.nomortelepon = inputnotelp.Text;

            string bacaData = File.ReadAllText("D:/Parsing.json");

            List<db_register> listJson = JsonConvert.DeserializeObject<List<db_register>>(bacaData);
            listJson.Add(userRegister);
            var data = JsonConvert.DerializeObject(listJson, Formatting.Indented);
            File.WriteAllText("D:/Parsing.json", data);
        }

        // Menyimpan file JSON ke lokasi path yang ada di parameter dengan tipe generik yang dimasukan.
        public static void SaveToJson("C:/Users/lenovo/Documents/File json")
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText("C: /Users/lenovo/Documents/File json, json");
            }
    }
}
