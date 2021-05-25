using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeDeneme
{
    public class NarenciyeSıkacagı : IMeyveSıkacagı // narenciye sıkacağı adlı bir class oluşturdum ve IMeyveSıkacağı interface özelliğinden miras aldırdım 
    {
        public Form1 Form1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MeyveSık(Meyve meyve) // meyve sık fonksiyonu 
        {
            if (meyve.Isim=="portakal") // eğer meyve portakal ise bu kod bloğu çalışır 
            {
                meyve.Sıvı = (meyve.Agirlik*meyve.Verim)/100; //sıvı oranını hesaplayan kısım 
                meyve.VitA = (meyve.Sıvı / 100) * 225; // vitamin A değerini hesaplayan kısım 
                meyve.VitC = (meyve.Sıvı / 100) * 45; // vitamin c değerini hesaplar 

            }
            if (meyve.Isim == "greyfurt") //greyfurt ise bu kod bloğu çalışır 
            {
                meyve.Sıvı = (meyve.Agirlik * meyve.Verim) / 100; //sıvı oranını hesaplayan kısım 
                meyve.VitA = (meyve.Sıvı / 100) * 3; // vitamin A değerini hesaplayan kısım 
                meyve.VitC = (meyve.Sıvı / 100) * 44; // vitamin c değerini hesaplar 

            }
            if (meyve.Isim == "mandalina") // mandalina ise bu kod bloğu
            {
                meyve.Sıvı = (meyve.Agirlik * meyve.Verim) / 100; //sıvı oranını hesaplayan kısım 
                meyve.VitA = (meyve.Sıvı / 100) * 681; // vitamin A değerini hesaplayan kısım 
                meyve.VitC = (meyve.Sıvı / 100) * 26; // vitamin c değerini hesaplar 

            }
        }
    }
}
