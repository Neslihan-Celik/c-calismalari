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
    public partial class birim : Form
    {
        public birim()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)

            {

            long x = 0; //Long  bir değişken tanımladım

            int n = 0;  // int  bir değişkentanımladım

            try     
                
            {
                if (txtsayi.Text == "") { txtsayi.Text = "0"; } else { x = int.Parse(txtsayi.Text); }

                //textbox1 deki değeri x'e attık.
                if (txttaban.Text == "") { txttaban.Text = "0"; } else { n = int.Parse(txttaban.Text); }
                //textbox2 deki değeri n'e attık.

                lblSonuc.Text = tabancevir(x, n);
                }

                catch (Exception)

                {
                    throw; 
                }

            }

            string tabancevir(long x, int n)
            { 
                if (n < 2) 

                    return "-1";// taban 2'den küçük olursa hata için koyduk

            long b; //  Mod atmak için.

                string s = ""; 

                while (x >= n)
                { // Sayı tabandan küçük olana kadar döngü döncek.

                    b = x % n;   // sayının tabandaki kalanı alıp, b ye at

                    x = x / n;// Sayı sürekli tabana böl ve x in değeri değişiyor
        
            if (b > 9) // Eğer sayının tabana bölümünde kalan 9 dan büyükse 

                        s = (char)(55 + b) + s; 
            /*  ascii Karakter Tablosunda Başlangıç Olan A harfinin Değeri 
             *  65  bu yüzden böyle bir işlem yaptık. 9 dan büyük olan  sayılar harfe dönüştürülecek  kburada .*/

                    else
                        s = b + s;
                }
                if (x > 9)

                    s = (char)(55 + x) + s;
                else
                    s = x + s;

                return s;

            }

        private void btn_diger_sayfalar_Click(object sender, EventArgs e)
        {//geri butonu
            anaSayfa f2 = new anaSayfa();
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//temizle butonu
            txtsayi.Text = "";
            txttaban.Text = "";
           lblSonuc.Text = "";
        }

        private void deger(object sender, KeyPressEventArgs e)
        {//textboxlara sadece sayı girilsin diye kontrol
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void birim_Load(object sender, EventArgs e)
        {

        }
    }
    }
 

