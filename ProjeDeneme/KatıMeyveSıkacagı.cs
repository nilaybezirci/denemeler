using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeDeneme
{
    public class KatıMeyveSıkacagı : IMeyveSıkacagı // katı meyve sıkacağı diye bi class oluşturdum meyve sıkacağı interface inden kalıtım aldı 
    {
        public Form1 Form1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MeyveSık(Meyve meyve) // meyve sık fonksiyonunu çağırdım 
        {
            if (meyve.Isim=="elma") //meyve elma ise bu kod bloğu çalışır 
            {
                meyve.Posa = (meyve.Agirlik * meyve.Verim) / 100; //posa değerini hesaplayan sayısal işlemler 
                //vitamın A ve C değerini hesaplayan sayısal işlemler 
                meyve.VitA = (meyve.Posa / 100) * 54;
                meyve.VitC = (meyve.Posa / 100) * 5;
            }
            if (meyve.Isim == "armut") //meyve armut ise bu kod bloğu çalışır 
            {
                meyve.Posa = (meyve.Agirlik * meyve.Verim) / 100; //posa değerini hesaplayan sayısal işlemler 
                //vitamın A ve C değerini hesaplayan sayısal işlemler 
                meyve.VitA = (meyve.Posa / 100) * 25;
                meyve.VitC = (meyve.Posa / 100) * 5;
            }
            if (meyve.Isim == "cilek") //meyve çilek ise bu kod bloğu çalışır 
            {
                meyve.Posa = (meyve.Agirlik * meyve.Verim) / 100;//posa değerini hesaplayan sayısal işlemler 
                //vitamın A ve C değerini hesaplayan sayısal işlemler 
                meyve.VitA = (meyve.Posa / 100) * 12;
                meyve.VitC = (meyve.Posa / 100) * 60;
            }
        }
    }
}
