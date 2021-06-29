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
