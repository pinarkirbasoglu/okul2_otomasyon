using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Okul2_Otomasyonu
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            short KisiSay = Convert.ToInt16(Interaction.InputBox("kaç kişi gireceksiniz:"));
            Kisi[] kisiler=new Kisi[KisiSay];
            int sayac = 0;
            for(int i =0;i<kisiler.Length;i++)
            {
                bool kontrol = false;
                int tcn = Convert.ToInt32(Interaction.InputBox("tc no girin"));
                foreach(Kisi gel in kisiler)
                {
                    if(gel != null)
                    {
                        if (gel.Tcn==tcn)
                        {
                            kontrol = true;
                            Interaction.InputBox("bu tc nolu kişi sada önceden girilmiştir lütfen başka bir tc no girin.");
                            break;
                        }//dizi tcn ile kontrol et
                    }//dizi boş değilse kontrol et
                }//foreach
                if (kontrol == true)
                {
                    i--;
                    continue;
                }//if ile continue yani varsa orda başa dön yeni kisi oluşturma.
                byte secim = Convert.ToByte(Interaction.InputBox("1-Öğrenci, 2-Personel"));
                switch (secim)
                {
                    case 1:
                        Ogrenci ogr = new Ogrenci()
                        {
                            Tcn = tcn,
                            Ad_soyad =Interaction.InputBox(" öğrenci ad soyad girin:"),
                            Ogno=Convert.ToInt32(Interaction.InputBox("öğrenci no girin")),
                            Bolum=Interaction.InputBox("öğrenci bölümü girin:"),
                            Adres=AdrGir()
                        };
                        kisiler[i]= ogr;
                        break;
                   case 2:
                        Personel per = new Personel()
                        {
                            Tcn = tcn,
                            Ad_soyad = Interaction.InputBox(" personel ad soyad girin:"),
                            Perno = Convert.ToInt32(Interaction.InputBox("personel no girin")),
                            Brans = Interaction.InputBox("personel bölümü girin:"),
                            Adres = AdrGir()
                        };
                        kisiler[i] = per;
                        break;
                }//switch
                sayac++;
                int cvp = Convert.ToInt32(Interaction.MsgBox("devam edecek misiniz?", MsgBoxStyle.YesNo));
                if (cvp == 7) break;
            }//for
            Array.Resize(ref kisiler, sayac);
            foreach(Kisi kisim in kisiler)
            {
                //gelenelri üst sınıf türündeki dizde tutuğumuz için alt sınıfların özelleikleri için cast edicez.
                if (kisim is Ogrenci) ListBox1.Items.Add(((Ogrenci)kisim).OgrBil());
                if (kisim is Personel) ListBox1.Items.Add(((Personel)kisim).PerBil());
            }
        }//button click
        //adres bilgisini alıp adres bilgilerini döndüren metot oluşturuyoruz bu sayfada hep kullana bileceğiz 
        private Adres AdrGir()
        {
            //adres bilgilerini aldık
            Adres adr = new Adres()
            {
                Ilce=Interaction.InputBox("ilçe giriniz"),
                Mahalle=Interaction.InputBox("mahalle giriniz:")
            };
            return adr;//adres bilgilerini Adres clası özelliğinde döndürdük
        } 
    }
}