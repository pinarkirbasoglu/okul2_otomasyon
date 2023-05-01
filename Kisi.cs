using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul2_Otomasyonu
{
    public class Kisi
    {
        private string ad_soyad;
        private int tcn;
        private Adres adres;

        public string Ad_soyad { get => ad_soyad; set => ad_soyad = value; }
        public int Tcn { get => tcn; set => tcn = value; }
        public Adres Adres { get => adres; set => adres = value; }

        protected string KisiBil()
        {
            return "ad-soyad:" + Ad_soyad + " " + "TC no:" + Tcn + " " + "Adres:" + Adres.adrBil();

        }
    }
}