/***********************************************************************************************************************
 ***********************************
 **SAKARYA ÜNİVERSİTESİ 
 **BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 **BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ 
 **NESNEYE DAYALI PROGRAMLAMA DERSİ 
 **2020-2021 BAHAR DÖNEMİ 
 **ÖDEV NUMARASI :proje ödevi
 **ÖĞRENCİ ADI:MEDİNA NİLAY BEZİRCİ 
 **ÖĞRENCİ NO:B201210035
 **DERSİN ALINDIĞI GRUP :1.ÖĞRETİM B GRUBU 
 *************************************************************************************************************************
 *******************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjeDeneme
{
    public partial class Form1 : Form
    {
        Meyve meyve = new Meyve();
        int zaman = 60; //int tipinde zaman değişkeni oluşturup 60 değerini atadım 
        double toplamAgirlik = 0; //double tipinde toplam ağırlık değerini oluşturdum başlangıç değeri olarak 0 atadım 
        double toplamVitA = 0;//double tipinde toplam vitamin A değerini oluşturdum başlangıç değeri olarak 0 atadım 
        double toplamVitC = 0;//double tipinde toplam vitamin c değerini oluşturdum başlangıç değeri olarak 0 atadım 
        double toplamSıvı = 0;//double tipinde toplam sıvı değerini oluşturdum başlangıç değeri olarak 0 atadım 
        double toplamPosa = 0;//double tipinde toplam posa değerini oluşturdum başlangıç değeri olarak 0 atadım 
        public void MeyveGetir() // meyve getir fonksiyonunu tanımladım 
        {
            Random random = new Random(); // random bir merve gelmesi için random fonksiyonu kullandım 

            Elma elma = new Elma() { 
                Isim="elma",
                Cesit="Katı",
                Agirlik=random.Next(70,120), // ağırlık ve verimi rastgele bir değer alır 
                Verim=random.Next(80,95) 
            };
            Portakal portakal = new Portakal() {
                Isim = "portakal",
                Cesit = "Narenciye",
                Agirlik = random.Next(70, 120), 
                Verim = random.Next(30, 70),
            };
           Cilek cilek = new Cilek()
           {
                Isim = "cilek",
                Cesit = "Katı",
                Agirlik = random.Next(70, 120),// ağırlık ve verimi rastgele bir değer alır 
               Verim = random.Next(80, 95),
           };
           Mandalina mandalina = new Mandalina()
            {
                Isim = "mandalina",
                Cesit = "Narenciye",
                Agirlik = random.Next(70, 120),// ağırlık ve verimi rastgele bir değer alır 
               Verim = random.Next(30, 70),
            };
            Armut armut = new Armut()
            {
                Isim = "armut",
                Cesit = "Katı",
                Agirlik = random.Next(70, 120),// ağırlık ve verimi rastgele bir değer alır 
                Verim = random.Next(80, 95),
            };
           Greyfurt greyfurt  = new Greyfurt()
            {
                Isim = "greyfurt",
                Cesit = "Narenciye",
                Agirlik = random.Next(70, 120),// ağırlık ve verimi rastgele bir değer alır 
               Verim = random.Next(30, 70),
            };


            Meyve[] meyveler = new Meyve[] {  
              elma,portakal,cilek,greyfurt,armut,mandalina 
            }; //Meyveler adlı bir dizi oluşturdum 

            meyve = meyveler[random.Next(0, 6)]; // meyvelerin random gelmesi için 
            MeyveSıkacagıKulan(meyve);


            pictureBox1.Image = Image.FromFile(meyve.Isim+".jpg"); //picturebox a resimler gelir
            label1.Text = "Meyve:   " + meyve.Isim; //meyvenin ismi ve değerleri  label a yazdırılır
            label2.Text = "Ağırlık:  " + meyve.Agirlik.ToString();
            label3.Text = "Verim:  " + meyve.Verim.ToString();
            label4.Text = "Vitamin A:  " + Math.Round(meyve.VitA, 3).ToString();
            label5.Text = "Vitamin C:  " + Math.Round(meyve.VitC, 3).ToString();
            if (meyve.Cesit == "Narenciye") // eğer meyve narenciye ise 
            {
                label6.Text = "Sıvı:  " + Math.Round(meyve.Sıvı, 3).ToString(); // sıvı değeri yazdırılır 
            }
            else
            {
                label6.Text = "Posa:  " + Math.Round(meyve.Posa, 3).ToString(); //katı meyve ise posa değeri yazdırılır 
            }

        }
        public void MeyveSıkacagıKulan(Meyve meyve) { //Meyve sıkacağı kullan adlı bir fonksiyon 

            KatıMeyveSıkacagı katıMeyveSıkacagı = new KatıMeyveSıkacagı();
            NarenciyeSıkacagı narenciyeSıkacagı = new NarenciyeSıkacagı();

            if (meyve.Cesit == "Katı") // eğer meyve katı meyve ise 
            {
                katıMeyveSıkacagı.MeyveSık(meyve); //katı meyve sıkacağı kullanılır
            }
            else
            {
                narenciyeSıkacagı.MeyveSık(meyve); //narenciye ise narenciye sıkacağı kullanılır
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)  //başla  Butonu 
        {
            button1.Enabled = false; // oyun başladıktan sonra süre bitinceye kadar başla butonu inaktif durumda kalır
            button3.Enabled = true; // katı meyve sıkacağı butonu aktif hale gelir 
            button4.Enabled = true;//narenciye butonu aktif hale gelir
            //meyvelerin değerlerine başlangıç değeri olarak 0 verdim 
            toplamAgirlik = 0;
            toplamPosa = 0;
            toplamSıvı = 0;
            toplamVitA = 0;
            toplamVitC = 0;
            
            label8.Text = "";
            label9.Text = "";
            label11.Text = "";
            label14.Text = "";
            label16.Text = "";

            richTextBox1.Clear(); //başla butonuna her basıldığında yani yeni oyun için richtextbox temizlenir
           

            zaman = 60; 
            timer1.Start(); // sayaç başlatılır

            MeyveGetir(); 
        }

        private void button2_Click(object sender, EventArgs e) //çıkış butonu 
        {
            this.Close(); // çıkışa bastığımızda oyun kapanır 
        }

        private void button3_Click(object sender, EventArgs e) // katı meyve butonu
        {
            if (meyve.Cesit == "Katı") // eğer meyve katı meyve ise 
            {
                toplamAgirlik += meyve.Agirlik;
                toplamVitA += meyve.VitA;
                toplamVitC += meyve.VitC;
                toplamPosa += meyve.Posa;

                //değerler label a yazdırılır 
                label8.Text = Math.Round(toplamAgirlik, 3).ToString();
                label9.Text = Math.Round(toplamVitA, 3).ToString();
                label11.Text = Math.Round(toplamVitC, 3).ToString();
                label14.Text= Math.Round(toplamPosa, 3).ToString();

                // değerler richtextbox a yazdırılır 
                richTextBox1.AppendText(Environment.NewLine + "Meyve İsmi" + ":  " + meyve.Isim + ":   ");
                richTextBox1.AppendText(Environment.NewLine + "Vitamin A" + ":  " + ":   " + Math.Round(meyve.VitA).ToString());
                richTextBox1.AppendText(Environment.NewLine + "Vitamin C" + ":   " + ":   " + Math.Round(meyve.VitC).ToString());
                richTextBox1.AppendText(Environment.NewLine + "Ağırlık" + ":    " + ":   " + Math.Round(meyve.Agirlik).ToString());
                richTextBox1.AppendText(Environment.NewLine + "Verim" + ":   " + ":   " + Math.Round(meyve.Verim).ToString());
                richTextBox1.AppendText(Environment.NewLine + "-----------------------------------------");
                MeyveGetir();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (meyve.Cesit == "Narenciye") // eğer meyve çeşidi narenciye ise

            {
                toplamAgirlik += meyve.Agirlik;
                toplamSıvı += meyve.Sıvı;
                toplamVitA += meyve.VitA;
                toplamVitC += meyve.VitC;

                label8.Text = Math.Round(toplamAgirlik, 3).ToString();
                label9.Text = Math.Round(toplamVitA, 3).ToString();
                label11.Text = Math.Round(toplamVitC, 3).ToString();
                label16.Text = Math.Round(toplamSıvı, 3).ToString();
                //verileri richtextbox a yazdıran kodlar 
                richTextBox1.AppendText(Environment.NewLine + "Meyve İsmi" + ":  " + meyve.Isim + ":   " );
                richTextBox1.AppendText(Environment.NewLine + "Vitamin A" +":  "+ ":   " + Math.Round(meyve.VitA).ToString());
                richTextBox1.AppendText(Environment.NewLine + "Vitamin C"+":   "+  ":   " + Math.Round(meyve.VitC).ToString());
                richTextBox1.AppendText(Environment.NewLine + "Ağırlık" +":    "+  ":   " + Math.Round(meyve.Agirlik).ToString());
                richTextBox1.AppendText(Environment.NewLine + "Verim" +":   "+  ":   " + Math.Round(meyve.Verim).ToString());
                richTextBox1.AppendText(Environment.NewLine + "------------------------------------------" );
                MeyveGetir();
            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e) // süre sayacı
        {
            if (zaman >= 0) // Süre 0 dan büyük olduğu sürece azalmaya devam eder.
            {
                int sayac = zaman--;
                label13.Text = sayac.ToString();
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Stop();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
