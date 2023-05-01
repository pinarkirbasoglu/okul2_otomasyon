using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul2_Otomasyonu
{
    public class Personel:Kisi
    {
        private int perno;
        private string brans;

        public int Perno { get => perno; set => perno = value; }
        public string Brans { get => brans; set => brans = value; }

        public string PerBil()
        {
            return KisiBil() + " " + "personel no:" + Perno + " " + "branşı:" + Brans;
        }
    }
}