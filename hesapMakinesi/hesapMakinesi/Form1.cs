using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string islem="+";
        double sonuc=0 ,sayi1=0,sayi2=0;

        private void btn_secim(object sender, EventArgs e)
        {// burada buton nesnesinin üstündeki yazıyı txt_hesaba attık sender ile
         // Böylece tek tek her tuş için fonksiyon ve event tanımlamadık
            if (txt_hesap.Text == "0")
            {
                txt_hesap.Text = "";
            }
            txt_hesap.Text = txt_hesap.Text + ((Button)sender).Text;
        }
        private void txt_hesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char ile gelen değer sayısal değil ise ve 8 (space ) ise değerleri txt_hesaba yazma
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8 )
            {
                e.Handled = true;
            }  
        }
        private void btn_virgul_Click(object sender, EventArgs e)
        {/* virgül koymak için önce txt_hesap içinde virgül 
         * araması yapıp index nuarası numarasınsa göre virgül koyduk
         */
            if (txt_hesap.Text.IndexOf(",") < 0)
            {
                txt_hesap.Text = txt_hesap.Text + ",";
            } 
        }
        private void btn_eksiIsaret_Click(object sender, EventArgs e)
        {

            //if (txt_hesap.Text.IndexOf("-") < 0)
            //{
            //    txt_hesap.Text = txt_hesap.Text + "-";
            //}
            /* iki farklı şekilde eksi koyma */
           txt_hesap.Text= (Convert.ToDouble(txt_hesap.Text) * -1).ToString();//textteki değeri alıp - ile çarptık
        }

        private void btn_arti_Click(object sender, EventArgs e)
        {//kontrol den sonra sayi1 değeri txt_hesaba eşitlendi
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 =Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();// burada görsellik için labele daha önceki işlem atıldı
            txt_hesap.Text = "";// temizlik yapıldı
            islem = "+";// yapılan işlem belirlendi
            
        }

        private void btn_eksi_Click(object sender, EventArgs e)
        {// artı butonu ile aynı işlemler yapıldı
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();
            txt_hesap.Text = "";
            islem = "-";
        }
        private void btn_carpi_Click(object sender, EventArgs e)
        {// artı butonu ile aynı işlemler yapıldı
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();
            txt_hesap.Text = "";
            islem = "x";
        }
        private void btn_bol_Click(object sender, EventArgs e)
        {// artı butonu ile aynı işlemler yapıldı
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();
            txt_hesap.Text = "";
            islem = "/";
        }
        private void btn_esittir_Click(object sender, EventArgs e)
        { 
            if(islem=="^"|| islem == "!"||islem == "√¯")
            {//burusı tek değer alınması gereken durumlar için tek değerle işlem yapılması için
                hesapla(islem, sayi1);
                lbl_islemTut.Text = (islem + " "+sayi1 + " = " + sonuc);
            }
            else
            {// iki değer ile işlem yapılalar için farklı bir fonksiyon kuruldu
                if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }   
                sayi2 = Convert.ToDouble(txt_hesap.Text);
                hesapla(islem, sayi1, sayi2);
                lbl_islemTut.Text = ((sayi1).ToString() + " " + islem + " " +sayi2 + " = " + sonuc);
            }
            temizle();// temizlik için kullanılan fonksiyon
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {// delete tuşu tek karakter sil
            //txt_hesap'taki değerleri sayıp bir eksiğini alıp tekrar eşitlemesini yaptık substring ile
            txt_hesap.Text = txt_hesap.Text.Substring(0, txt_hesap.Text.Length - 1);
            if (txt_hesap.Text == "")// kontrol kısmı eğer boş ise sıfıra eşitleme yaptık
            {
                txt_hesap.Text = "0";
            }
        }
        private void btn_C_Click(object sender, EventArgs e)
        {// herşeyi sil tuşu
         // labaelleri ve textboxu boşalltık
            txt_hesap.Text = "";
            lbl_islemTut.Text = "";
            lbl_sonuc.Text = "";
        }
        private void btn_CE_Click(object sender, EventArgs e)
        {// sadece txt_hesap temizlendi 
            txt_hesap.Text = "0";
        }
        private void btn_faktoriyel_Click(object sender, EventArgs e)
        {//artı işlemi ile aynı sadecetek bir değer ile işlem yapıcak
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();
            txt_hesap.Text = "";
            islem = "!";
        }
        private void btn_yuzde_Click(object sender, EventArgs e)
        {
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();
            txt_hesap.Text = "";
            islem = " % ";
        }
        private void btn_karekok_Click(object sender, EventArgs e)
        {
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = (sayi1).ToString();
            txt_hesap.Text = "";
            islem = "√¯";
        }
        private void btn_us_Click(object sender, EventArgs e)
        {
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = ((sayi1).ToString() + islem);
            txt_hesap.Text = "";
            islem = " ^ ";
            /*kare al ve üs al bir birine çok benzeyen işaretlere sahip ama birinin switch 
             içinde sağ ve solda boşluklu diğerini boşluksuz olarak işleme tabi tuttuk*/
        }
        private void btn_kare_Click(object sender, EventArgs e)
        {
            if (txt_hesap.Text == "") { txt_hesap.Text = "0"; }
            sayi1 = Convert.ToDouble(txt_hesap.Text);
            lbl_islemTut.Text = ((sayi1).ToString()+islem);
            txt_hesap.Text = "";
            islem = "^";
        }
        public void hesapla(string islem, double sayi1)
        {// bu kısımım sadece tek değer ile işlem yapanlar için olan fonksiyon
            
            switch (islem)
            {
                case "√¯":// kareKök alma
                    sonuc = Math.Sqrt(sayi1);
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString("0.00"));
                    //virgülden sonra sadece iki karakter aldırmak için
                    break;
                case "!":// faktöriyel
                    sonuc = 1;// burayı açıklamaya gerek yok =)
                    for (int i=1;i<=sayi1;i++)
                    {
                        sonuc *= i;
                    } 
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString());
                    break;
                case "^":// karesini alma
                    sonuc = sayi1 * sayi1;
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString());   
                    break;
            }
        }
        public void temizle()// text içini boşaltmak için
        {
           txt_hesap.Text = "0";
        }
        public void hesapla(string islem, double sayi1,double sayi2)
        {// iki değerle işlem yapan butonların kısmı
            
            switch (islem)
            {
                case "+"://artı 
                    sonuc = sayi1 + sayi2;
                   lbl_sonuc.Text= ("Sonuç :"+sonuc.ToString("0.00"));
                    break;
                 case "-":// eksi
                    sonuc = sayi1 - sayi2;
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString("0.00"));
                    break;
                case "x":// çarpı
                    sonuc = sayi1 * sayi2;
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString("0.00"));
                    break;
                case "/":// bölü
                    sonuc = sayi1 / sayi2;
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString("0.00"));
                    break;
                case " % "://mod
                    sonuc = (sayi1%sayi2);
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString());
                    break;
                case " ^ ":// üs alma
                    sonuc = Math.Pow(sayi1 , sayi2);
                    lbl_sonuc.Text = ("Sonuç :" + sonuc.ToString("0.00"));
                    break;  
            }
        }

       
    }
}
