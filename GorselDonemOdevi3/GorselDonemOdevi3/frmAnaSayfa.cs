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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        frmYanSayfa yan ;// Yan sayfa üretildi kullanım için
        private void btnSeciliEkle_Click(object sender, EventArgs e)// seçim yapılan eleman ekleme
        {
            if (lstOgrenci.SelectedIndex != -1)// seçim yoksa diye koruma
            {
                lstKatilimci.Items.Add(lstOgrenci.SelectedItem);// listeye seçili elemanı ekleme
                lstOgrenci.Items.Remove(lstOgrenci.SelectedItem);// olunan listediki elemanları silme

            }
            else
            {
                MessageBox.Show("Seçili eleman yok !");// seçim yoksa uyarı verme
            }

        }

        private void btnSeciliCikart_Click(object sender, EventArgs e)
        {//ekle butonu ile tamamen aynı işlemler sadece yönler farklı

            if (lstKatilimci.SelectedIndex != -1)
            {
                lstOgrenci.Items.Add(lstKatilimci.SelectedItem);
                lstKatilimci.Items.Remove(lstKatilimci.SelectedItem);

            }
            else
            {
                MessageBox.Show("Seçili eleman yok !");
            }
        }

        private void btnHepsiniEkle_Click(object sender, EventArgs e)
        {// hepsini ekle
            if (lstOgrenci.Items.Count != 0)// kontrol liste boşmu diye
            {
                for (int i = 0; i < lstOgrenci.Items.Count; i++)
                {//listenin eleman sayısı kadar dön ve diğer listeye bu listedeki elemanı ekle

                    lstKatilimci.Items.Add(lstOgrenci.Items[i]);
                }
                lstOgrenci.Items.Clear();// olunana listeyi temizle
            }
            else
            {
                MessageBox.Show("Listede eleman yok !");// liste boş olma durumu için uyarı
            }
        }

        private void btnHepsiniCikart_Click(object sender, EventArgs e)
        {// bir önceki butonla tamamen aynı fakat yön farklı
            if (lstKatilimci.Items.Count != 0)
            {
                for (int i = 0; i < lstKatilimci.Items.Count; i++)
                {
                    lstOgrenci.Items.Add(lstKatilimci.Items[i]);
                }
                lstKatilimci.Items.Clear();
            }
            else
            {
                MessageBox.Show("Listede eleman yok !");
            }
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {// yan sayfaya geçiş butonu
            yan = new frmYanSayfa();

            for (int i = 0; i < lstKatilimci.Items.Count; i++)
            {//listenin eleman sayısı kadar dön ve yan sayfadaki listeye bu elemanları tek tek ekle
                yan.lstInceleme.Items.Add (lstKatilimci.Items[i]);

            }

            yan.Show();// burada sadece göster dedim ardından bu sayfayı gizle dedim
            this.Hide();
        }
    }
}
