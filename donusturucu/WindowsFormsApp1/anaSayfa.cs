using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void btn_Hesap_Click(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            hesap.Show();
            this.Hide();
        }

        private void btn_birim_Click(object sender, EventArgs e)
        {

            birim birim = new birim();
            birim.Show();
            this.Hide();

        }

        private void btnBirim2_Click(object sender, EventArgs e)
        {
            birimDonusum birimDonusum = new birimDonusum();
            birimDonusum.Show();
            this.Hide();
        }
    }
}
