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
    public partial class birimDonusum : Form
    {
        public birimDonusum()
        {
            InitializeComponent();
        }

        private void birimDonusum_Load(object sender, EventArgs e)
        {
            temizle();
            temizle2();
            temizle3();
        }

        private void txtDeger_KeyPress(object sender, KeyPressEventArgs e)
        {//burası textboxa sadece sayısal değer girilmesi için var
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_diger_sayfalar_Click(object sender, EventArgs e)
        {//geri butonu
            anaSayfa f2 = new anaSayfa();
            f2.Show();
            this.Hide();
        }

       

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        //-------------------------------------------------------------------------------------------------------
        // burası uzunluk kısmı
        private void txtuzunluktemizle_Click(object sender, EventArgs e)
        {//temizleme butonu
            temizle();
        }
        public void temizle() {
            txtmilimetre.Text ="0";
            txtsantimetre.Text = "0";
            txtmetre.Text = "0";
            txtkilometre.Text = "0";
        }
        private void btnmilimetre_Click(object sender, EventArgs e)
        {
          string  x = txtmilimetre.Text;
            temizle();
            txtmilimetre.Text = x;
            txtsantimetre.Text = (double.Parse(x)/10).ToString(); 
            txtmetre.Text = (double.Parse(x) / 1000).ToString();
            txtkilometre.Text = (double.Parse(x) / 100000).ToString();
        }

        private void btnsantimetre_Click(object sender, EventArgs e)
        {
            string x = txtsantimetre.Text;
            temizle();
            txtmilimetre.Text = (double.Parse(x) * 10).ToString();
            txtsantimetre.Text = x;
            txtmetre.Text = (double.Parse(x) / 100).ToString();
            txtkilometre.Text = (double.Parse(x) / 10000).ToString();
        }

        private void btnmetre_Click(object sender, EventArgs e)
        {
            string x = txtmetre.Text;
            temizle();
            txtmilimetre.Text = (double.Parse(x) * 1000).ToString();
            txtsantimetre.Text = (double.Parse(x) * 100).ToString();
            txtmetre.Text = x;
            txtkilometre.Text = (double.Parse(x) / 1000).ToString();
        }

        private void btnkilometre_Click(object sender, EventArgs e)
        {
            string x = txtkilometre.Text;
            temizle();
            txtmilimetre.Text = (double.Parse(x) * 1000000).ToString();
            txtsantimetre.Text = (double.Parse(x) * 100000).ToString();
            txtmetre.Text = (double.Parse(x) * 1000).ToString();
            txtkilometre.Text = x;
        }

       

        //-------------------------------------------------------------------------------------------------------
        // burası kilo  kısmı
        public void temizle2()
        {
            txtmiligram.Text = "0";
            txtgram.Text = "0";
            txtkilo.Text = "0";
            txtton.Text = "0";
        }
        private void btnagirliktemizle_Click(object sender, EventArgs e)
        {
            temizle2();
        }
        private void btnmiligram_Click(object sender, EventArgs e)
        {
            string x = txtmiligram.Text;
            temizle2();
            txtmiligram.Text = x;
            txtgram.Text = (double.Parse(x) / 1000).ToString();
            txtkilo.Text = (double.Parse(x) / 100000).ToString();
            txtton.Text = (double.Parse(x) /1000000000).ToString();
          

        }  
        private void btngram_Click(object sender, EventArgs e)
        {
            string x = txtgram.Text;
            temizle2();
            txtmiligram.Text = (double.Parse(x) * 1000).ToString();
            txtgram.Text = x;
            txtkilo.Text = (double.Parse(x) / 1000).ToString();
            txtton.Text = (double.Parse(x) / 1000000).ToString();


        }
        private void btnkilo_Click(object sender, EventArgs e)
        {
            string x = txtkilo.Text;
            temizle2();
            txtmiligram.Text = (double.Parse(x) * 1000000).ToString();
            txtgram.Text = (double.Parse(x) *1000).ToString();
            txtkilo.Text = x;
            txtton.Text = (double.Parse(x) / 1000).ToString();
        }
        private void btnton_Click(object sender, EventArgs e)
        {
            string x = txtton.Text;
            temizle2();
            txtmiligram.Text = (double.Parse(x) * 1000000000).ToString();
            txtgram.Text = (double.Parse(x) * 1000000).ToString();
            txtkilo.Text = (double.Parse(x) *1000).ToString();
            txtton.Text = x;
        }
        //-------------------------------------------------------------------------------------------------------
        // burası zaman  kısmı
        public void temizle3()
        {
            txtsaniye.Text = "0";
            txtdakika.Text = "0";
            txtsaat.Text = "0";
            txtgun.Text = "0";
            txtyil.Text = "0";
        }

        private void btntzamantemizle_Click(object sender, EventArgs e)
        {
            temizle3();
        }

        private void btnsaniye_Click(object sender, EventArgs e)
        {
           
            string x = txtsaniye.Text;
            temizle3();
            txtsaniye.Text = x;
            txtdakika.Text = (double.Parse(x) /60).ToString();
            txtsaat.Text = (double.Parse(x) /3600).ToString();
            txtgun.Text = (double.Parse(x) /86400).ToString();
            txtyil.Text = (double.Parse(x) /1036800).ToString();
        }

        private void btndakika_Click(object sender, EventArgs e)
        {

            string x = txtdakika.Text;
            temizle3();
            txtsaniye.Text = (double.Parse(x) * 60).ToString();
            txtdakika.Text =x;
            txtsaat.Text = (double.Parse(x) / 60).ToString();
            txtgun.Text = (double.Parse(x) / 1440).ToString();
            txtyil.Text = (double.Parse(x) / 17280).ToString();
        }

        private void btnsaat_Click(object sender, EventArgs e)
        {
            string x = txtsaat.Text;
            temizle3();
            txtsaniye.Text = (double.Parse(x) *36000).ToString();
            txtdakika.Text = (double.Parse(x) * 60).ToString();
            txtsaat.Text = x;
            txtgun.Text = (double.Parse(x) / 24).ToString();
            txtyil.Text = (double.Parse(x) / 288).ToString();
        }

        private void btngun_Click(object sender, EventArgs e)
        {
            string x = txtgun.Text;
            temizle3();
            txtsaniye.Text = (double.Parse(x) * 86400).ToString();
            txtdakika.Text = (double.Parse(x) * 1440).ToString();
            txtsaat.Text = (double.Parse(x) *24).ToString();
            txtgun.Text = x;
            txtyil.Text = (double.Parse(x) / 365).ToString();
        }
    }
}
