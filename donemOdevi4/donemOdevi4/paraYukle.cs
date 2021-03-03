using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donemOdevi4
{
    public partial class paraYukle : Form
    {
        public paraYukle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPara.Text == "")
            {
                txtPara.Text = "0";
            }
            lblGuncelTutar.Text = (Convert.ToInt32(txtPara.Text)+ Convert.ToInt32(lblGuncelTutar.Text)).ToString();
            anaSayfa ana = new anaSayfa();
            ana.lblBakiye.Text = lblGuncelTutar.Text;
            this.Close();
            ana.Show();
        }
    }
}
