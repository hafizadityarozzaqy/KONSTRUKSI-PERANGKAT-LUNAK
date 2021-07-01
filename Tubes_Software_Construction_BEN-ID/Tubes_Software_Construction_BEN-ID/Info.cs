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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lblemail.Text = Parameter.email;
            lblnamalengkap.Text = Parameter.namalengkap;
            lbluname.Text = Parameter.uname;
            lblpass.Text = Parameter.pass;
        }
    }
}
