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
    public partial class IsiBBM : Form
    {
        static BakaraTabelDriven.BBM id = BakaraTabelDriven.BBM.PERTAMAX;
        public string BBM = id.ToString();
        public string Harga = BakaraTabelDriven.GetHarga(id);

        public IsiBBM()
        {
            InitializeComponent();
        }

        private void BakaraIsiBBM_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembayaran pm = new Pembayaran();
            pm.Show();
        }
    }
}
