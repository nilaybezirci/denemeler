using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeDeneme
{
    public class Meyve //meyve classı oluşturup ortak özellikleri burada tanımladım 
    {
        public string Isim { get; set; } // String veri tipinde İsim özelliğini tanımladım 

        // double veri tipinde sayısal özellikleri tanımladım
        public double VitA { get; set; } 
        public double VitC { get; set; }
        public double Agirlik { get; set; }
        public double Verim { get; set; }
        public double Posa { get; set; }
        public double Sıvı { get; set; }
        public string Cesit { get; set; } // string veri tipinde Çesit özelliğini tanımladım 

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }
    }
}
