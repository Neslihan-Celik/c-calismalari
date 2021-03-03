using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifirdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 ;


        private void tekEkle_Click(object sender, EventArgs e)
        {
            if (liste1.SelectedIndex != -1) {
                liste2.Items.Add(liste1.SelectedItem);
                liste1.Items.Remove(liste1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seçili elaman yok");
            }
        }

        private void tekCikart_Click(object sender, EventArgs e)
        {
            if (liste2.SelectedIndex != -1)
            {
                liste1.Items.Add(liste2.SelectedItem);
                liste2.Items.Remove(liste2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seçili elaman yok");
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (liste1.Items.Count != 0)
            {
                for (int i = 0; i < liste1.Items.Count; i++) 
                {
                    liste2.Items.Add(liste1.Items[i]);   
                }
                liste1.Items.Clear();
                }          
            else
            {
                MessageBox.Show("Eleman yok");
            }
        }

        private void cikart_Click(object sender, EventArgs e)
        {

            if (liste2.Items.Count != 0)
            {
                for (int i = 0; i < liste2.Items.Count; i++)
                {
                    liste1.Items.Add(liste2.Items[i]);
                }
                liste2.Items.Clear();
            }
            else
            {
                MessageBox.Show("Eleman yok");
            }
        }

        private void incele_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            for (int i = 0; i < liste2.Items.Count; i++)
            {
                form2.kontrolListesi.Items.Add(liste2.Items[i]);
            }
            this.Hide();
            form2.Show();
        }
    }
}
