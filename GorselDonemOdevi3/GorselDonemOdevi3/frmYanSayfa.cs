using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselDonemOdevi3
{
    public partial class frmYanSayfa : Form
    {
        public frmYanSayfa()
        {
            InitializeComponent();
        }
        frmAnaSayfa ana = new frmAnaSayfa();// ana sayfa üretildi kullanım için

        private void frmYanSayfa_Load(object sender, EventArgs e)
        {// başlangıçta kişi bilgilerini alıp bilgiVer fonksiyonuna gönderdik
            bilgiVer(lstInceleme.Items.Count);// bir int değer alıyor bizde listenin eleman sayısını verdik
        }
        private void btnKaydet_Click(object sender, EventArgs e)// kayedet butonu
        {
            for (int i = 0; i < lstInceleme.Items.Count; i++)
            {// listenin eleman sayısı kadar dön ve ana sayfadaki listeye güncel liste elemanlarını ekle
                ana.lstKatilimci.Items.Add(lstInceleme.Items[i]);
            }
            kontrolEt(lstInceleme.Items.Count);//kontrolEt fonksiyonuna int değer olarak listenin eleman saysını gönderdik
            this.Hide();// bu sayfayı gizle ana sayfayı aç
            ana.Show();

        }
        private void lstInceleme_SelectedIndexChanged(object sender, EventArgs e)
        {//listededen bir eleman seçilmesi durumunda textbox'a bilgi gönderme
            if (lstInceleme.SelectedIndex != -1)//kontrol
            {
                txtKisiGir.Text = lstInceleme.SelectedItem.ToString();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {//her iki sayfadan da çık
            this.Close();
            ana.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (lstInceleme.SelectedIndex != -1)// kontrol
            {/*daha önce yapılan kodlama ile listeden bir eleman seçildiğinde 
              * otomatik textbox' gidiyor burada o elemanı sildik heryerden*/
                lstInceleme.Items.Remove(lstInceleme.SelectedItem);
                txtKisiGir.Text = "";//textbox temizleme
                bilgiVer(lstInceleme.Items.Count);//bilgiVer fonksiyonu çağrıldı
            }
            else
            {
                MessageBox.Show("Seçili değer yok!");// mesaj verme
            }
        }
         private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (txtKisiGir.Text.Length != 0)// kotrol textbox boşmu diye
            {
                lstInceleme.Items.Add(txtKisiGir.Text);// liste güncelleme
                ana.lstMisafir.Items.Add(txtKisiGir.Text);// ana sayfadaki misafire değer gönderme
                txtKisiGir.Text = ("");// temizleme
                bilgiVer(lstInceleme.Items.Count);
            }
            else
            {
                MessageBox.Show("Değer boş olamaz !");
            }
        }

       
        void bilgiVer(int sayi)
        {/*bilgiver fonksiyonu gelen int değere göre bilgi veren 
          *labelin rengini yazı rengini ve renk kutusunu günceller
          ve gelen int değeri labele yazar.*/
            lblKisiGosterim.ForeColor = Color.White;
            if (sayi <= 5)
            {
                lblKisiGosterim.BackColor = Color.Red;
                pbxRenk.BackColor = Color.Red;
                lblKisiGosterim.Text = "Kişi sayısı : " + sayi.ToString();
            }
            else if (sayi > 5 && sayi <= 10)
            {
                lblKisiGosterim.BackColor = Color.Orange;
                pbxRenk.BackColor = Color.Orange;
                lblKisiGosterim.Text = "Kişi sayısı : " + sayi.ToString();
            }
            else if (sayi > 10 && sayi <= 15)
            {
                lblKisiGosterim.BackColor = Color.Aqua;
                pbxRenk.BackColor = Color.Aqua;
                lblKisiGosterim.Text = "Kişi sayısı : " + sayi.ToString();
            }

            else
            {
                lblKisiGosterim.BackColor = Color.Green;
                pbxRenk.BackColor = Color.Green;
                lblKisiGosterim.Text = "Kişi sayısı : " + sayi.ToString();
            }
        }
        void kontrolEt(int sayi)
        {/*kontrolEt fonksiyonu gelen değere göre uyarı mesajının içeriğini 
          * değiştirir ve gösterir ayrıca gelen değeri de mesajın içeriğine ekler.*/
            if (sayi <= 5)
            {
                MessageBox.Show("Kişi sayısı yetersiz!\n Kişi sayısı : " + sayi);
            }
            else if (sayi > 5 && sayi <= 10)
            {
                MessageBox.Show("Kişi sayısı idare eder !\nKişi sayısı : " + sayi);
            }
            else if (sayi > 10 && sayi <= 15)
            {
                MessageBox.Show("Kişi sayısı iyi!\nKişi sayısı : " + sayi);
            }
            else
            {
                MessageBox.Show("Uçmuşuz da haberimiz yokmuş !\nKatılımcı sayısı çok iyi !\nKişi sayısı : " + sayi);
            }

        }

    }
    }
