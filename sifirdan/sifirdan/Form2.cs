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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 form1;
        private void kaydet_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = kontrolListesi.Items.Count;

            if(sayi<5)
            {
                MessageBox.Show("sayı az =>"+sayi);
            }
            else if (sayi > 5&& sayi<10)
            {
                MessageBox.Show("sayı idare =>" + sayi);
            }
            else if (sayi > 10&& sayi<15)
            {
                MessageBox.Show("sayı iyi =>" + sayi);
               }
            else
            {
                MessageBox.Show("sayı muhteşem =>" + sayi);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int sayi;
            sayi = kontrolListesi.Items.Count;
            if (sayi < 5)
            {
                resim.BackColor = Color.Red;
                yazi.Text = "katılımcı sayısı : " + sayi.ToString();

            }
            else if (sayi > 5 && sayi < 10)
            {
                resim.BackColor = Color.Orange;
                yazi.Text = "katılımcı sayısı : " + sayi.ToString();
            }
            else if (sayi > 10 && sayi < 15)
            {
                resim.BackColor = Color.Yellow;
                yazi.Text = "katılımcı sayısı : " + sayi.ToString();
            }
            else
            {
                resim.BackColor = Color.Purple;
                yazi.Text = "katılımcı sayısı : " + sayi.ToString();
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
           
            form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
