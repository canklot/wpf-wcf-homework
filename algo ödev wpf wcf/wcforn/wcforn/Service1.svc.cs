using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcforn
{
    public class Kullanici
    {
        public string ad;
        public string soyad;
        public string email;
        public long tel;
        public string sifre;
        public string sifretekrar;
        
    }
    public class Uruns
    {
        public string urunadi;
        public string imagesource;
        public int fiyat;
        public string urunaciklamasi;
        public int height;
        public int width;
    }
    public class IletisimF
    {
        public string adsoyad;
        public string email;
        public long tel;
        public string konu;
        public string mesaj;
    }
    public class liste
    {
        public static List<Uruns> urunlist = new List<Uruns>();
        public static List<Kullanici> Kullanicilist = new List<Kullanici>();
        public static List<IletisimF> MesajList = new List<IletisimF>();
    }
    
    public class Service1 : IService1
    {
        public Random rastgele = new Random();
        


        public string giris(string email, string sifre)
        {
            for (int i=0;i<liste.Kullanicilist.Count;i++)
            {
                if (liste.Kullanicilist.ElementAt(i).email == email && liste.Kullanicilist.ElementAt(i).sifre==sifre)
                {
                    return "Giriş işlemi başarılı";
                }
               
            }

            
            return "E-mail veya şifre yanlış";
        }
        int x;
        public int guvenlikkodugndr()
        {
             x = rastgele.Next(1000, 9999);
            
            return x;
        }

        public void iletisimformual(string adsoyad, string email, long tel, string konu, string mesaj)
        {
            IletisimF iletisimF = new IletisimF();
            iletisimF.adsoyad = adsoyad;
            iletisimF.email = email;
            iletisimF.tel = tel;
            iletisimF.konu = konu;
            iletisimF.mesaj = mesaj;
            liste.MesajList.Add(iletisimF);
        }

        public string kayitol(string ad, string soyad, string sifre,string sifretekrar, long tel,string email)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.ad = ad;
            kullanici.soyad = soyad;
            kullanici.sifre = sifre;
            kullanici.sifretekrar = sifretekrar;
            kullanici.email = email;
            kullanici.tel = tel;
            string telctrl = tel.ToString();


            if (sifretekrar != sifre)
            {
                return "Şifreler eşleşmiyor şifrenizi tekrar giriniz";
            }
            
            else if (telctrl.Length != 11)
            {
                return "Telefon Numarası 11 haneli olmalıdır";  
            }
                      
            else {
                
                liste.Kullanicilist.Add(kullanici);
                return "Uye oldunuz";
            }           
            
        }

        public string sifremiunuttum(string email)
        {
            for(int i=0;i<liste.Kullanicilist.Count;i++)
            {
                if (email == liste.Kullanicilist.ElementAt(i).email)
                {
                    return liste.Kullanicilist.ElementAt(i).sifre;
                }
                
            }
            
            return "E-mailinizi yanlış girdiniz";
        }

        public void bilgigetir( string email,ref string ad,ref string soyad,ref string sifre,ref long tel)
        {
            for(int i = 0; i < liste.Kullanicilist.Count; i++)
            {
                if (email == liste.Kullanicilist.ElementAt(i).email)
                {
                    ad = liste.Kullanicilist.ElementAt(i).ad;
                    soyad = liste.Kullanicilist.ElementAt(i).soyad;
                    sifre = liste.Kullanicilist.ElementAt(i).sifre;
                    tel = liste.Kullanicilist.ElementAt(i).tel;
                }
            }
        }

        public string tcnoctrl(string tcno)
        {
            int sh = tcno[tcno.Length - 1] - '0';
            if (tcno.Length != 11)
            {
                return "TC kimlik numarası 11 haneli olmalıdır";
            }            
            else { return "1"; }
        }

        public void urunbilgigetir(string urunad, int urunfiyat, string imagesource, string urunaciklamasi, int width, int height)
        {
            Uruns urun = new Uruns();
            urunad = urun.urunadi;
            urunfiyat = urun.fiyat;
            imagesource = urun.imagesource;
            urunaciklamasi = urun.urunaciklamasi;
            width = urun.width;
            height = urun.height;
        }
    }
}
