using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonemOdevi3
{
    
    
    public partial class frmYanSayfa : Form
    {
        public frmYanSayfa()
        {
            InitializeComponent();
        }
      

        int yuzde;

        

        public void labelYaz(int yuzde)
        {
           lblYuzdeGosterim.Text = "Kişi Sayısı : " + yuzde.ToString();
            Console.WriteLine(yuzde);
        }
        public void kontrolEt(int yuzde)
        {
            labelYaz(yuzde);
            lblYuzdeGosterim.ForeColor = Color.White;
            if (yuzde <= 5)
            {
                MessageBox.Show("Kişi sayısı yetersiz !");
                lblYuzdeGosterim.BackColor = Color.Red;
                pbxRenk.BackColor = Color.Red;
             
            }
           else if (yuzde > 5&& yuzde <=10)
            {
                MessageBox.Show("Kişi sayısı idare eder !");
                lblYuzdeGosterim.BackColor = Color.Orange;
                pbxRenk.BackColor = Color.Orange;
             
            }
            else if (yuzde >10 && yuzde <= 15)
            {
                MessageBox.Show("Kişi sayısı fena değil !");
                lblYuzdeGosterim.BackColor = Color.Yellow;
                pbxRenk.BackColor = Color.Yellow;
               
            }
            else if (yuzde > 15 && yuzde <= 20)
            {
                MessageBox.Show("Kişi sayısı iyi !");
                lblYuzdeGosterim.BackColor = Color.Green;
                pbxRenk.BackColor = Color.Green;
            
            }
            else if (yuzde > 20 && yuzde <= 25)
            {
                MessageBox.Show("Kişi sayısı çok iyi !");
                lblYuzdeGosterim.BackColor = Color.Blue;
                pbxRenk.BackColor = Color.Blue;
             
            }
            else  
            {
                MessageBox.Show("Uçmuşuz da haberimiz yokmuş !");
                lblYuzdeGosterim.BackColor = Color.Purple;
                pbxRenk.BackColor = Color.Purple;
              
            }

        }
        /* Diğer sayfa kodları
         
         private void labelYaz(int yuzde)
        {
            lblYuzdeGosterim.Text = "Kişi Sayısı : " + yuzde.ToString();
            Console.WriteLine(yuzde);
        }

        private void kontrolEt(int yuzde)
        {
            labelYaz(yuzde);
            lblYuzdeGosterim.ForeColor = Color.White;
            if (yuzde <= 5)
            {
                MessageBox.Show("Kişi sayısı yetersiz !");
                lblYuzdeGosterim.BackColor = Color.Red;
                pbxRenk.BackColor = Color.Red;

            }
            else if (yuzde > 5 && yuzde <= 10)
            {
                MessageBox.Show("Kişi sayısı iyi eder !");
                lblYuzdeGosterim.BackColor = Color.Orange;
                pbxRenk.BackColor = Color.Orange;

            }
           
            else
            {
                MessageBox.Show("Uçmuşuz da haberimiz yokmuş !");
                lblYuzdeGosterim.BackColor = Color.Green;
                pbxRenk.BackColor = Color.Green;

            }

        }*/
        private void frmYanSayfa_Load(object sender, EventArgs e)
        {
            frmAnaSayfa ana = new frmAnaSayfa();

            for (int i = 0; i <ana.listBox3.Items.Count; i++)
            {
                lstInceleme.Items.Add(ana.listBox3.Items[i]);
            }
            
            yuzde = lstInceleme.Items.Count;
            kontrolEt(yuzde);


        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAnaSayfa ana = new frmAnaSayfa();

            ana.Show();// ana sayfayı gösterdim
            this.Close();// bir daha kullanılmayacağında bu formu kappattım
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            frmAnaSayfa ana = new frmAnaSayfa();
            if (lstInceleme.SelectedIndex!=-1)
            {
                ana.listBox3.Items.Remove(lstInceleme.SelectedItem.ToString());
                lstInceleme.Items.Remove(lstInceleme.SelectedItem.ToString());
                txtKisiGir.Text = "";
            }
            else
            {
                MessageBox.Show("Seçili değer yok!");
            }
            int yuzde;
            yuzde = lstInceleme.Items.Count;
            kontrolEt(yuzde);
        }
        private void lstInceleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInceleme.SelectedIndex != -1)
            {
                txtKisiGir.Text = lstInceleme.SelectedItem.ToString();
            }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtKisiGir.Text.Length!=0)
            {
                lstInceleme.Items.Add(txtKisiGir.Text);
                txtKisiGir.Text = ("");
            }
            else
            {
                MessageBox.Show("Değer boş olamaz !");
            }
            int yuzde;
            yuzde = lstInceleme.Items.Count;
            kontrolEt(yuzde);
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmAnaSayfa ana = new frmAnaSayfa();

            Console.WriteLine("-----------------------");
            for (int i = 0; i < lstInceleme.Items.Count; i++)
            {
               ana.listBox3.Items.Clear();
                ana.listBox3.Items.Add(lstInceleme.Items[i]);
                Console.WriteLine("-");
            }
            //this.ana.Show();// ana sayfayı gösterdim
            //this.();// bir daha kullanılmayacağında bu formu kappattım
          // this.ana.Show();
            //this.Close();
        }

        private void txtKisiGir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
