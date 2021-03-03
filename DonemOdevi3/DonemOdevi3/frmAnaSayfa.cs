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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
           
            InitializeComponent();
            
        }

        frmYanSayfa yan = new frmYanSayfa();





        private void btnSeciliEkle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                    listBox3.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                 
            }
            else
            {
                MessageBox.Show("Seçili eleman yok !");
            }
            
        }

        private void btnSeciliCikart_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                    listBox1.Items.Add(listBox3.SelectedItem);
                    listBox3.Items.Remove(listBox3.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seçili eleman yok !");
            }
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
        

            if (listBox1.Items.Count != -1)
            {
                for(int i=0;i< listBox1.Items.Count; i++)
                {
                    
                    listBox3.Items.Add(listBox1.Items[i]);
                 }
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Listede eleman yok !");
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
          
            if (listBox3.Items.Count != -1)
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
                listBox3.Items.Clear();
            }
            else
            {
                MessageBox.Show("Listede eleman yok !");
            }
        }
        public  void btnIncele_Click(object sender, EventArgs e)
        {
          yan = new frmYanSayfa();

            for (int i=0;i<listBox3.Items.Count;i++)
            {
                yan.lstInceleme.Items[i] = listBox3.Items[i];
                
            }
            
            yan.Show();// burada sadece göster dedim ardından bu sayfayı gizle dedim
            this.Hide();

            
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
         yan = new frmYanSayfa();
            if (yan.lstInceleme.Items.Count != 0)
            {
                for (int i = 0; i < yan.lstInceleme.Items.Count; i++)
                {
                    
                    listBox3.Items.Add(yan.lstInceleme.Items[i]);
                }

            }
        }
    }
}
