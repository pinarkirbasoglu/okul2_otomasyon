using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul2_Otomasyonu
{
    public class Ogrenci:Kisi
    {
        private int ogno;
        private string bolum;

        public int Ogno { get => ogno; set => ogno = value; }
        public string Bolum { get => bolum; set => bolum = value; }

        public string OgrBil()
        {
            return KisiBil() + " " + "öğrenci no:" + Ogno + " " + "bölüm adı:" + Bolum;
        }
    }
}