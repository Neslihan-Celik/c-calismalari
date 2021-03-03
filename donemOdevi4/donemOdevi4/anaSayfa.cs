using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace donemOdevi4
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        public void hesap(int adet,string urun,int fiyat)
        {
            liste1.Items.Add(urun);
            liste2.Items.Add(fiyat);
            listeSayi.Items.Add(adet);
            lblHesapTutar.Text = (Convert.ToInt32( lblHesapTutar.Text)+ fiyat).ToString();
        }
        public void kontrolEt(int adet, string urun, int fiyat)
        {
            int  harcanan = Convert.ToInt32(lblHesapTutar.Text);
            int  bakiye = Convert.ToInt32(lblBakiye.Text);

            ArrayList arama = new ArrayList();
            foreach (string elaman in liste1.Items)
            {
                arama.Add(elaman);
            }
            if (arama.IndexOf(urun) > -1)
            {
           
                if (harcanan >= bakiye)
                {
                    MessageBox.Show("Bakiye yetersiz ! ");
                }
                else
                { 
                    listeSayi.Items[liste1.FindString(urun)] = (Convert.ToInt32(listeSayi.Items[liste1.FindString(urun)]) + 1);
                    liste2.Items[liste1.FindString(urun)] = (Convert.ToInt32(liste2.Items[liste1.FindString(urun)]) + fiyat);
                    lblHesapTutar.Text = (Convert.ToInt32(lblHesapTutar.Text) + fiyat).ToString();
                }
               
            }
            else
            {
                hesap(adet, urun, fiyat);
            }
        }
        public void urunSil(int adet,string urun, int fiyat)
        {
            if(adet==0|| fiyat==0 )
            {
                int secim = liste1.FindString(liste1.SelectedItem.ToString());
                liste1.Items.Remove(liste1.SelectedItem.ToString());
                liste2.Items.Remove(secim);
                listeSayi.Items.Remove(secim);
                liste1.SelectedIndex = -1;
            }
            else 
            {
                listeSayi.Items[liste1.FindString(urun)] = (Convert.ToInt32(listeSayi.Items[liste1.FindString(urun)]) - 1);
                liste2.Items[liste1.FindString(urun)] = (Convert.ToInt32(liste2.Items[liste1.FindString(urun)]) - fiyat);
                lblHesapTutar.Text = (Convert.ToInt32(lblHesapTutar.Text) - fiyat).ToString();
                liste1.SelectedIndex = -1;
            }
               
            
        }
        private void anaSayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUrun1_Click(object sender, EventArgs e)
        {
                  //miktar ürün adı fiyat
          kontrolEt(1, "ürün1", 500);
        }

        private void btnUrun2_Click(object sender, EventArgs e)
        {
            kontrolEt(1, "ürün2", 600);
           
        }

        private void btnUrun3_Click(object sender, EventArgs e)
        {
            kontrolEt(1, "ürün3", 900);
            
        }

        private void btnUrun4_Click(object sender, EventArgs e)
        {
            kontrolEt(1, "ürün4", 1000);
           
        }

        private void btnUrun5_Click(object sender, EventArgs e)
        {
            kontrolEt(1, "ürün5", 2500);
          
        }

        private void btnTmm_Click(object sender, EventArgs e)
        {
            lblBakiye.Text = (Convert.ToInt32(lblBakiye.Text) - Convert.ToInt32(lblHesapTutar.Text)).ToString();
            MessageBox.Show("Alışveriş tamamlandı \nKalan bakiyeniz :" + lblBakiye.Text+" TL");
            liste1.Items.Clear();
            liste2.Items.Clear();
            listeSayi.Items.Clear();
            lblHesapTutar.Text = "0";

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            liste1.Items.Clear();
            liste2.Items.Clear();
            listeSayi.Items.Clear();
            lblHesapTutar.Text = "0";
        }

        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            paraYukle  yukle  = new paraYukle();
            yukle.lblGuncelTutar.Text = lblBakiye.Text;
            yukle.Show();
            this.Hide();
           
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
           
            if (liste1.SelectedIndex == -1|| liste2.SelectedIndex !=-1|| listeSayi.SelectedIndex!=-1)
            {
                MessageBox.Show("Lütfen ürün Listesinden bir ürün seçin ! ");
                liste2.SelectedIndex = -1;
                listeSayi.SelectedIndex = -1;
            }
            else
            {
                int fiyat;
                string urun = liste1.SelectedItem.ToString();
                int adet = Convert.ToInt32(listeSayi.Items[liste1.FindString(urun)]);
                if (adet == 0)
                {
                    fiyat = 0;

                }
                else
                {

                    fiyat = (Convert.ToInt32(liste2.Items[liste1.FindString(urun)]) / (Convert.ToInt32(listeSayi.Items[liste1.FindString(urun)])));
                }
               
                urunSil(1, urun, fiyat);
            }
           
        }
    }
}
