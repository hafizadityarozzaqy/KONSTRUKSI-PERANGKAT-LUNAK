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
    private void button1_Click(object sender, EventArgs e)
    {
        var userPembayaran = new db_pembayaran();
        userPembayaran.Nama = inputNama.Text;
        userPembayaran.Jenis Bensin = inputBensin.Text;
        userPembayaran.Liter = inputLiter.Text;
        userPembayaran.Harga = inputHarga.Text;
        userPembayaran.MetodePembayarann = Pembayarann.Text;

        string bacaData = File.ReadAllText("C:/Users/lenovo/Documents/db_user.Json");

        List<db_pembayaran> listJson = JsonConvert.DeserializeObject<List<db_register>>(bacaData);
        listJson.Add(userRegister);
        var data = JsonConvert.SerializeObject(listJson, Formatting.Indented);
        File.WriteAllText("C:/Users/lenovo/Documents/db_user.Json", data);
    }
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnKEMBALI_Click(object sender, EventArgs e)
        {
            new isiBBM().Show();
            this.Hide();
        }

        private void BtnSALDO_Click(object sender, EventArgs e)
        {
            new Barcode().Show();
            this.Hide();
        }

        private void BtnMBANKING_Click(object sender, EventArgs e)
        {
            new Barcode().Show();
            this.Hide();
        }

        private void BtnDANA_Click(object sender, EventArgs e)
        {
            new Barcode().Show();
            this.Hide();
        }

        private void BtnOVO_Click(object sender, EventArgs e)
        {
            new Barcode().Show();
            this.Hide();
        }

        private void BtnLINKAJA_Click(object sender, EventArgs e)
        {
            new Barcode().Show();
            this.Hide();
        }
    }
}
