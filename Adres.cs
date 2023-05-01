using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul2_Otomasyonu
{
    public class Adres
    {
        private string ilce;
        private string mahalle;

        public string Ilce { get => ilce; set => ilce = value; }
        public string Mahalle { get => mahalle; set => mahalle = value; }

        public string adrBil()
        {
            return "ilçe:" + Ilce + " " + "mahalle:" + Mahalle;
        }
    }
}