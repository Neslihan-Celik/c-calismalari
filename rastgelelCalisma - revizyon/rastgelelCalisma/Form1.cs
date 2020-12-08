using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgelelCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public class insan
        {
            public String ad = "";
            public String soyAd = "";
            public String yas = "";
            public String memleket = " ";

            public string[] isimler = { "ahmet", "mehmet", "ayşe","fatma","cemile","gül","selma" ,"azim","ela","elif","ebru","sedat"};
            public string[] SoyIsimler = { "çat", "gür", "taş","çelik","coşkun","demir","sarı","adil","salim"};
            public string[] sehirler = { "istanbul","ankara","şanlıurfa","edirne","bursa","elazığ","giresun","samsun","tokat","ardahan","diyarbakır","kars"};
            public Random rnd = new Random();
            
            public string adGetir()
            {
                return this.ad;
            }
            public string soyAdGetir()
            {
                return this.soyAd;
            }
            public string yasGetir()
            {
                return this.yas;
            }
            public string memleketGetir()
            {
                return this.memleket;
            }
            public void BilgiGetir()
            {
                Console.WriteLine("\nKişi bilgisi \nAd : "+this.adGetir()+
                                  "\nSoyad : "+this.soyAdGetir()+
                                  "\nYaş :"+this.yasGetir()+
                                  "\nMemleket :"+this.memleketGetir());
            }
            public void bilgiGir(string ad, string soyAd, string yas,string memleket)
            {
                this.ad = ad;
                this.soyAd = soyAd;
                this.yas = yas;
                this.memleket = memleket;

            }
            public void  randomKisi()
            {
                int dgr1 = rnd.Next(isimler.Length);
                int dgr2 = rnd.Next(SoyIsimler.Length);
                int dgr3 = rnd.Next(0,90);
                int dgr4 = rnd.Next(sehirler.Length);
                this.ad = this.isimler[dgr1];
                this.soyAd = this.SoyIsimler[dgr2];
                this.yas = dgr3.ToString();
                this.memleket = this.sehirler[dgr4];

                Console.WriteLine(String.Join(" ", dgr1, dgr2, dgr3, dgr4)); 
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            insan a = new insan();
            
            
           a.bilgiGir("ali", "veli", "25","gümüşhane");
           txt_yazi.Text=("Bu kişi bilgisini biz atadık " +
                        "\n\nKişi bilgisi : \nAd : " + a.adGetir()+
                        "\nSoyad : "+a.soyAdGetir() +
                        "\nYaş:"+a.yasGetir()+
                        "\nMemleket : "+a.memleketGetir());

            a.BilgiGetir();
            a.randomKisi();
            txt_yazi2.Text = ("Bu kişi bilgisi tamamen rastgele şekilde üretilmiştir " +
                            "\n\nKişi bilgisi : \nAd : " + a.adGetir() +
                            "\nSoyad : " + a.soyAdGetir() + 
                            "\nYaş:" + a.yasGetir() + 
                            "\nMemleket : " + a.memleketGetir());
            
           for(int i=0;i<5;i++)
            {
                    a.randomKisi();
                     txt_yazi3.Text += ("\n\n"+ (i+1) + ".kişi bilgisi : \nAd : " + a.adGetir() + 
                                        "\nSoyad : " + a.soyAdGetir() + 
                                        "\nYaş:" + a.yasGetir() + 
                                        "\nMemleket : " + a.memleketGetir());
                    a.BilgiGetir();
           }

        }
    }
}
