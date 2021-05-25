/***********************************************************************************************************************
 ***********************************
 **SAKARYA ÜNİVERSİTESİ 
 **BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 **BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ 
 **NESNEYE DAYALI PROGRAMLAMA DERSİ 
 **2020-2021 BAHAR DÖNEMİ 
 **ÖDEV NUMARASI :2.2
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixİşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int[,] matrixA,matrixB,toplam,transpoze,carpim ;
        private  void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);// kullanıcın girdiği a boyutunu textbox3'ten aldım 
            matrixA = new int  [a,a]; //axa tipinde bir matrix oluşturdum 
            int c =0;
            for (int i = 0; i < a; i++) //matrixin satırlarını oluşturan kod 
            {
                for (int j = 0; j < a; j++)// matrixin sütunlarını oluşturan kod 
                {
                    matrixA[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1)+ ".Satır" + (j + 1)+ ".Sütuna sayı giriniz", "sayı giriniz ", "", 40, 40)); //kullanıcıdan matrixin elemanlarını aldım 
                    textBox1.Text = textBox1.Text + matrixA[i, j]+" " ; 
                    
                    if (i==j)// matrix izini yazdıran kod 
                    {
                        c = matrixA[i, j] + c;
                        label6.Text = c.ToString ();//matrix izini label6 ya yazdırdım 
                    }
                }
                textBox1.Text = textBox1.Text + "\r\n";//çarpma sonucunu textbox1 e yazdırdım 
            }
            
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { 
            // transpoze işlemlerinin yapıldığı kısım 
            int t = int.Parse(textBox3.Text);
            transpoze = new int[t, t];
            for (int i = 0; i < t; i++) 
            {
                for (int j = 0; j < t; j++)
                {
                    transpoze[i, j] = matrixB[j, i];
                    textBox6.Text = textBox6.Text + matrixB[j, i] + " " ;
                }
                textBox6.Text = textBox6.Text + " \r\n";
            }
            DosyayaYaz(textBox2,textBox6,"B Transpoze","Matris B"); //sonuçları dosyaya yazdırdım 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AxB_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string m = "";
           
             int a  = int.Parse(textBox3.Text);
            carpim = new int[a, a]; //axa tipinde bi çarpım matrixi oluşturdum 
            for (int i = 0; i < a; i++)
            {
                
                for (int j = 0; j < a; j++)
                {
                    
                    for (int k = 0; k < a; k++)
                    {
                      carpim[i,j] += matrixA[i,k] * matrixB[k,j]; // çarpma işlemini tanımladım 
                        //m=m + carpim [i,j]+" ";

                    }

                    //m = m + " \n";
                }
               
            }

            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < a; k++)
                {
                    m = m + string.Format(" {0,-5}", carpim[i, k].ToString());
                }
                m = m + "\n";
                
            }

            richTextBox1.Text = m; //sonucu richtextboxa yazdırdım 

            DosyayaYaz(textBox1,textBox2,richTextBox1," A * B "); //işlem sonucunu dosyaya yazdırdım 
        }

        private void button7_Click(object sender, EventArgs e)
        { //matrix tersi işlemleri 
            int d = int.Parse(textBox3.Text);
            float[,] birimMatrix = new float[2, 2];// 2x2 tipinde bir birim matrix tanımladım 
            birimMatrix[0, 0] = 1;
            birimMatrix[0, 1] = 0;
            birimMatrix[1, 0] = 0;
            birimMatrix[1, 1] = 1;

            int tut = 0; // tut ve çarp gibi değişkenler oluşturdurup başlangıç değeri olarak 0 atadım
            int  carp = 0;//
            for (int i = 0; i <2 ; i++) // matrixin satırlarını ve sütunlarını yazdırdım 
            {
                for (int j = 0; j < 1; j++)//
                {
                    if (i==j) //eğer ieşit j ise bu blok çalışacak 
                    {
                        tut = matrixA[i, j];

                        matrixA[i, j] = (matrixA[i, j] / tut);
                        matrixA[i, j + 1] = matrixA[i, j + 1] / tut;

                        birimMatrix[i, j] = (birimMatrix[i, j]) / tut;
                        birimMatrix[i, j + 1] = (birimMatrix[i, j + 1]) / tut;
                    }

                    else // değil ise bu blok çalışacak 
                    {
                        carp = matrixA[i, j];//1,0

                        matrixA[i, j] = matrixA[i, j] - (matrixA[i - 1, j] * carp);
                        matrixA[i, j + 1] = matrixA[i, j + 1] - (matrixA[i - 1, j + 1] * carp);

                        birimMatrix[i, j] = birimMatrix[i, j] - (birimMatrix[i - 1, j] * carp);
                        birimMatrix[i, j + 1] = birimMatrix[i, j + 1] - (birimMatrix[i - 1, j + 1] * carp);
                    }
                }

                    

                
            }
            for (int i = 1; i >= 0; i--)
            {
                for (int j = 1; j > 0; j--)
                {
                    if (i==j)
                    {
                        tut = matrixA[i, j];

                        matrixA[i, j] = (matrixA[i, j] / tut);
                        matrixA[i, j - 1] = matrixA[i, j - 1] / tut;

                        birimMatrix[i, j] = (birimMatrix[i, j]) / tut;
                        birimMatrix[i, j - 1] = (birimMatrix[i, j - 1]) / tut;
                    }

                    else
                    {
                        carp = matrixA[i, j];

                        matrixA[i, j - 1] = matrixA[i, j - 1] - (matrixA[i + 1, j] * carp);
                        matrixA[i, j] = matrixA[i, j] - (matrixA[i + 1, j] * carp);

                        birimMatrix[i, j - 1] = birimMatrix[i, j - 1] - (birimMatrix[i + 1, j - 1] * carp);
                        birimMatrix[i, j] = birimMatrix[i, j] - (birimMatrix[i + 1, j] * carp);
                    }


                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    textBox7.Text = textBox7.Text + birimMatrix[i,j]  + " "; // sonucu textboxa yazdırdım 
                }
                textBox7.Text = textBox7.Text + " \r\n"; 
            }
            DosyayaYaz(textBox1,textBox7,"A Tersi","Matris A"); // işlemleri dosyaya yazdırdım 
        }

        private void button8_Click(object sender, EventArgs e)
        { //B matrixinin tersini alan kodlar 
            int d = int.Parse(textBox3.Text);
            float[,] birimMatrix = new float[2, 2];
            birimMatrix[0, 0] = 1;
            birimMatrix[0, 1] = 0;
            birimMatrix[1, 0] = 0;
            birimMatrix[1, 1] = 1;

            int tut = 0;
            int carp = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (i == j)
                    {
                        tut = matrixB[i, j];

                        matrixB[i, j] = (matrixB[i, j] / tut);
                        matrixB[i, j + 1] = matrixB[i, j + 1] / tut;

                        birimMatrix[i, j] = (birimMatrix[i, j]) / tut;
                        birimMatrix[i, j + 1] = (birimMatrix[i, j + 1]) / tut;
                    }

                    else
                    {
                        carp = matrixB[i, j];//1,0

                        matrixB[i, j] = matrixB[i, j] - (matrixB[i - 1, j] * carp);
                        matrixB[i, j + 1] = matrixB[i, j + 1] - (matrixB[i - 1, j + 1] * carp);

                        birimMatrix[i, j] = birimMatrix[i, j] - (birimMatrix[i - 1, j] * carp);
                        birimMatrix[i, j + 1] = birimMatrix[i, j + 1] - (birimMatrix[i - 1, j + 1] * carp);
                    }
                }




            }
            for (int i = 1; i >= 0; i--)
            {
                for (int j = 1; j > 0; j--)
                {
                    if (i == j)
                    {
                        tut = matrixB[i, j];

                        matrixB[i, j] = (matrixB[i, j] / tut);
                        matrixB[i, j - 1] = matrixB[i, j - 1] / tut;

                        birimMatrix[i, j] = (birimMatrix[i, j]) / tut;
                        birimMatrix[i, j - 1] = (birimMatrix[i, j - 1]) / tut;
                    }

                    else
                    {
                        carp = matrixB[i, j];

                        matrixB[i, j - 1] = matrixB[i, j - 1] - (matrixB[i + 1, j] * carp);
                        matrixB[i, j] = matrixB[i, j] - (matrixB[i + 1, j] * carp);

                        birimMatrix[i, j - 1] = birimMatrix[i, j - 1] - (birimMatrix[i + 1, j - 1] * carp);
                        birimMatrix[i, j] = birimMatrix[i, j] - (birimMatrix[i + 1, j] * carp);
                    }


                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    textBox8.Text = textBox8.Text + birimMatrix[i, j] + " ";
                }
                textBox8.Text = textBox8.Text + " \r\n";
            }
            DosyayaYaz(textBox2,textBox8,"B Tersi","Matris B");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        public void DosyayaYaz(TextBox textBoxA,TextBox textBoxB,TextBox textBoxS,string islem) 
        { // burada dosyaya yazma işlemlerini gerçekleştirdim 
            
            string fileName = "matrix.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("----------------------------------\n");
            sw.WriteLine("Matrix A ");
            sw.Write(textBoxA.Text+"\n");
            sw.WriteLine("Matrix B ");
            sw.Write(textBoxB.Text+"\n");
            sw.WriteLine(islem);
            sw.Write(textBoxS.Text+"\n");
            sw.WriteLine("----------------------------------\n");
            sw.Close();
        }
        public void DosyayaYaz(TextBox textBoxA, TextBox textBoxB, RichTextBox textBoxS, string islem)
        {

            string fileName = "matrix.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("----------------------------------\n");
            sw.WriteLine("Matrix A ");
            sw.Write(textBoxA.Text + "\n");
            sw.WriteLine("Matrix B ");
            sw.Write(textBoxB.Text + "\n");
            sw.WriteLine(islem);
            sw.Write(textBoxS.Text + "\n");
            sw.WriteLine("----------------------------------\n");
            sw.Close();
        }
        public void DosyayaYaz(TextBox textBoxA, TextBox textBoxS, string islem,string matris)
        {

            string fileName = "matrix.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("----------------------------------\n");
            sw.WriteLine(matris);
            sw.Write(textBoxA.Text + "\n");
            
            sw.WriteLine(islem);
            sw.Write(textBoxS.Text + "\n");
            sw.WriteLine("----------------------------------\n");
            sw.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "matrix.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            StreamWriter sw = File.AppendText(path);
            sw.Write(textBox1.Text);
            sw.Write(textBox2.Text);
            sw.Write(textBox5.Text);
            sw.Write(textBox6.Text);
            sw.Write(textBox7.Text);
            sw.Write(textBox8.Text);

            
            sw.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        { // richtextboxta görüntülemek için yeni bi form oluşturdum 
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        { //yukarıda açıkladığım gibi diğer matrixin transpozesini alan kod 
            int t = int.Parse(textBox3.Text);
            transpoze = new int[t,t];
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    transpoze[i, j] = matrixA[j, i];
                    textBox5.Text = textBox5.Text + matrixA[j, i]+" " ;
                }
                textBox5.Text = textBox5.Text + " \r\n";
            }
            DosyayaYaz(textBox1, textBox5, "A Transpoze","Matris A"); // sonucu dosyaya yazdırıyorum 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            toplam = new int[a, a]; // axa tipinde bir toplam  matrixi tanımladım 
            for (int i = 0; i < a; i++) // matrixin satırlarını oluşturdum 
            {
                for (int j = 0; j <a; j++)//sütunlarını oluşturdum 
                {
                    toplam[i, j] = matrixA[i, j] + matrixB[i, j]; // toplama işlemini tanımladım 
                    textBox4.Text = textBox4.Text + toplam[i, j] + " "; // textboxa yazdırdım sonucu 
                }
                textBox4.Text = textBox4.Text + "\r\n";
            }
            DosyayaYaz(textBox1,textBox2,textBox4,"A + B"); // dosyaya yazdırdım 
        }

        private void button2_Click(object sender, EventArgs e)
        { // bmatrixini oluşturan kısım 
            int a = int.Parse(textBox3.Text);
            matrixB = new int[a, a];
            int d = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matrixB[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".Satır" + (j + 1) + ".Sütuna sayı giriniz", "sayı giriniz ", "", 40, 40));
                    textBox2.Text = textBox2.Text + matrixB[i, j] + " ";
                    if (i == j)
                    {
                        d = matrixB[i, j] + d;
                        label5.Text = d.ToString();
                    }


                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
            
        }
    }
}
