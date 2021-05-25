using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeDeneme
{
    public interface IMeyveSıkacagı // MeyveSıkacağı adlı bir interface oluşturdum
    {
        Form1 Form1 { get; set; }

        void MeyveSık(Meyve meyve); //meyve sık adlı fonksiyon 
    }
}
