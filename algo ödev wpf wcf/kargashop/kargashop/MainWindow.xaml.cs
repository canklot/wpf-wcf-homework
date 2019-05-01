using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using kargashop.ServiceReference1;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kargashop
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1Client client = new Service1Client();
        
            public  List<Urun> urunlist = new List<Urun>()
            {
                new Urun(){ ad="Marvel Tshirt", fiyat =30 , imagesource="rsm/marveltshirt.jpg",urunaciklamasi="rsm/1.PNG",width=600,height=319 },
                new Urun(){ ad="Atatürk İmza Tshirt", fiyat =30 , imagesource="rsm/imzatshirt.jpg" ,urunaciklamasi="rsm/2.PNG",width=600,height=755 },
                new Urun(){ ad="Star Gece Lambası", fiyat =35 , imagesource="rsm/stargecelambasi.jpg",urunaciklamasi="rsm/3.PNG",width=600,height=731 },
                new Urun(){ ad="Deadpool Figur", fiyat =75 , imagesource="rsm/deadpoolfigur.jpg",urunaciklamasi="rsm/4.PNG",width=600,height=163 },
                new Urun(){ ad="Game of Thrones Abajur", fiyat =70 , imagesource="rsm/gameofthronesab.jpg" },
                new Urun(){ ad="LOTR Abajur", fiyat =70 , imagesource="rsm/lotrab.jpg" },
                new Urun(){ ad="StarWars Abajur", fiyat =70 , imagesource="rsm/starwarsab.jpg" },
                new Urun(){ ad="Okul Abajur", fiyat =70 , imagesource="rsm/okulab.jpg" },
                new Urun(){ ad="934 Anahtarlık", fiyat =15 , imagesource="rsm/934an.jpg",urunaciklamasi="rsm/9.PNG",width=600,height=231 },
                new Urun(){ ad="Baby Groot Anahtarlık", fiyat =15 , imagesource="rsm/babygrootan.jpg",urunaciklamasi="rsm/10.PNG",width=600,height=231 },
                new Urun(){ ad="Temel Reis Anahtarlık", fiyat =15 , imagesource="rsm/temelreisan.jpg",urunaciklamasi="rsm/11.PNG",width=600,height=328 },
                new Urun(){ ad="Captain America Anahtarlık", fiyat =15 , imagesource="rsm/captainamericaan.jpg",urunaciklamasi="rsm/12.PNG",width=600,height=327 },
                new Urun(){ ad="Kurabiye Canavarı Saat", fiyat =20 , imagesource="rsm/kurabiyecanavarisa.jpg",urunaciklamasi="rsm/13.PNG",width=600,height=283 },
                new Urun(){ ad="Friends Saat", fiyat =20 , imagesource="rsm/friendssa.jpg" ,urunaciklamasi="rsm/14.PNG",width=600,height=250},
                new Urun(){ ad="Batman Saat", fiyat =20 , imagesource="rsm/batmansa.jpg",urunaciklamasi="rsm/15.PNG",width=600,height=252 },
                new Urun(){ ad="Game of Thrones Saat", fiyat =20 , imagesource="rsm/gameofthronessa.jpg",urunaciklamasi="rsm/16.PNG",width=600,height=249 },
                new Urun(){ ad="Hero Kolye", fiyat =30 , imagesource="rsm/herotk.jpg",urunaciklamasi="rsm/17.PNG",width=600,height=271 },
                new Urun(){ ad="Game of Thrones Kolye", fiyat =20 , imagesource="rsm/gameofthronestk.jpg",urunaciklamasi="rsm/18.PNG",width=600,height=271 },
                new Urun(){ ad="Panda Kolye", fiyat =20 , imagesource="rsm/pandatk.jpg",urunaciklamasi="rsm/19.PNG",width=600,height=400 },
                new Urun(){ ad="Saturn Kolye", fiyat =20 , imagesource="rsm/saturntk.jpg",urunaciklamasi="rsm/20.PNG",width=600,height=350 }


            };
            public List<Urun> sepetlist = new List<Urun>();

        public string kullaniciad;
        public string kullanicisoyad;
        public string kullaniciemail;
        public string kullanicisifre;
        public long kullanicitel;
        public int suankikullanici = 0;



        public class Urun
        {
            public string ad;
            public string imagesource;
            public int fiyat;
            public int adet;
            public string urunaciklamasi;
            public int width;
            public int height;
        }

        
        public MainWindow()
        {
            InitializeComponent();
            Sayfa.Content = new Anasayfaurunleri();
            
        }

        private void iletisimClick(object sender, RoutedEventArgs e)
        {
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new iletisim();
            Degisenbtn.Content = "İletişim";
        }
        private void ShowHideMenu(string storyboardhide, Button myButton, StackPanel pnl)
        {
            Storyboard sb = Resources[storyboardhide] as Storyboard;
            sb.Begin(pnl);
        }

        private void Sepetac(object sender, RoutedEventArgs e)
        {
            
            Kaydir("Sepetac", Sepet);
            
        }

        private void Kaydir(string storyboardhide,  StackPanel pnl)
        {
            Storyboard sb = Resources[storyboardhide] as Storyboard;
            sb.Begin(pnl);
        }

        private void Sepetkapa(object sender, RoutedEventArgs e)
        {
            Kaydir("Sepetkapa", Sepet);
        }

        private void Giriskapa(object sender, RoutedEventArgs e)
        {
            Kaydir("Giriskapa", Giris);
            Giris.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "rsm/sagmenu.jpg")));
        }

        private void Girisac(object sender, RoutedEventArgs e)
        {
            
            Kaydir("Girisac", Giris);

        }

        private void Yanmenuac(object sender, RoutedEventArgs e)
        {
            Kaydir("Yanmenuac", Yanmenu);
        }

        private void Yanmenukapa(object sender, RoutedEventArgs e)
        {
            Kaydir("Yanmenukapa", Yanmenu);
        }

        private void Abajurbttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Abajururunleri();
            Degisenbtn.Content = "ABAJUR/5 Ürün var";
            Kaydir("Yanmenukapa", Yanmenu);
        }

        private void Saatbttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Saaturunleri();
            Degisenbtn.Content = "Saatler/5 Ürün var";
            Kaydir("Yanmenukapa", Yanmenu);
        }

        private void Takıbttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Takurunleri();
            Degisenbtn.Content = "Takılar/5 Ürün var";
            Kaydir("Yanmenukapa", Yanmenu);
        }

        private void Anahtarlikbttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Anahtarlikurunleri();
            Degisenbtn.Content = "Anahtarlıklar/5 Ürün var";
            Kaydir("Yanmenukapa", Yanmenu);
        }

        private void Anasayfbttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Anasayfaurunleri();
            Degisenbtn.Content = "Anasayfa Ürünleri";
            Kaydir("siparisitamamlakapa", alisverisspnl);
            

        }

        private void YeniUyeOlBttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("Giriskapa", Giris);
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Yeniuyeol();
        }

        private void SifremiUnuttumBttn_Click(object sender, RoutedEventArgs e)
        {
            Kaydir("Giriskapa", Giris);
            Kaydir("urunpenceresikapa", urunstackp);
            Sayfa.Content = new Sifremiunuttum();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        private void sepeteekle_Click(object sender, RoutedEventArgs e)
        {
            int y = 0;
            sepetlist.Add(new Urun() { fiyat = Convert.ToInt32(urunfiyati.Content),adet= Convert.ToInt32(adet.Content) });
            Sepetbox.Items.Add(new Image() {Height=75, Width=75, Source = urunresm.Source });
            Sepetbox.Items.Add(new Label() { Content ="Ad: "+ urunadi.Content, Height = 30, Width = 200 });
            Sepetbox.Items.Add(new Label() { Content ="Fiyat: "+ urunfiyati.Content +" TL", Height = 30, Width = 200 });
            Sepetbox.Items.Add(new Label() { Content = "Adet: " + adet.Content + " TL", Height = 30, Width = 200 });
            for (int i = 0; i < sepetlist.Count; i++)
            {
                y += sepetlist.ElementAt(i).fiyat*sepetlist.ElementAt(i).adet;
            }
            tutar.Content ="Toplam Tutar: "+ y.ToString();
        }

        private void arti_Click(object sender, RoutedEventArgs e)
        {
            adet.Content = (Convert.ToInt32(adet.Content) + 1).ToString();
        }

        private void eksi_Click(object sender, RoutedEventArgs e)
        {
            adet.Content = (Convert.ToInt32(adet.Content) - 1).ToString();
            if (Convert.ToInt32(adet.Content) <= 1)
            {adet.Content="1"; }
            
        }
        int aracont = 0;
        private void urunara_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < urunlist.Count; i++)
            {
                if (urunlist.ElementAt(i).ad == urunaratextbx.Text)
                {
                    urunresm.Source= new BitmapImage(new Uri(urunlist.ElementAt(i).imagesource, UriKind.Relative));
                    urunadi.Content = urunlist.ElementAt(i).ad;
                    urunfiyati.Content = urunlist.ElementAt(i).fiyat;
                    aracont = 1;
                    Sayfa.Content = new acilanurun();
                    Kaydir("urunpenceresiac", urunstackp);
                }               
               
            }
            if (aracont == 0)
            {
                System.Windows.MessageBox.Show("Aradığınız ürün bulunamadı");
            }
        }
        int aramacont=0;
        private void aramabttn_Click(object sender, RoutedEventArgs e)
        {
            if (aramacont == 0)
            {
                Kaydir("Aramaac", aramastpnl);
                aramacont = 1;
            }
            else { Kaydir("Aramakapa", aramastpnl); aramacont = 0; }
        }

        private void satinal_Click(object sender, RoutedEventArgs e)
        {
            
            if (suankikullanici == 0) { Kaydir("Girisac", Giris);
                
                Giris.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "rsm/kırmızılı.jpg")));

            }
            else {

                int z = 0;
                if (sepetlist.Count != 0)
                {
                    for (int i = 0; i < sepetlist.Count; i++)
                    {
                        z += sepetlist.ElementAt(i).fiyat * sepetlist.ElementAt(i).adet;
                    }
                    sontutar.Content = "Toplam Tutar: " + z.ToString();
                    Kaydir("siparisitamamlaac", alisverisspnl);
                    Kaydir("Giriskapa", Giris);

                }
                else System.Windows.MessageBox.Show("Sepetiniz boş ");

            }
            Kaydir("Sepetkapa",Sepet);
        }

        private void uyeliksizalisverisbttn_Click(object sender, RoutedEventArgs e)
        {
            int z=0;
            if (sepetlist.Count != 0)
            {
                for (int i = 0; i < sepetlist.Count; i++)
                {
                    z += sepetlist.ElementAt(i).fiyat * sepetlist.ElementAt(i).adet;
                }
                sontutar.Content= "Toplam Tutar: " + z.ToString();
                Kaydir("siparisitamamlaac", alisverisspnl);
                Kaydir("Giriskapa", Giris);
                Giris.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "rsm/sagmenu.jpg")));
            }
            else System.Windows.MessageBox.Show("Sepetiniz boş ");
        }

        private void tabsonrakiadim_Click(object sender, RoutedEventArgs e)
        {
            if (client.tcnoctrl(tcktab.Text) == "1") { tabctrl.SelectedItem = ikinciadim; }
            else { System.Windows.MessageBox.Show(client.tcnoctrl(tcktab.Text)); }
            
            
        }

        private void Girisyapbttn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show(client.giris(emailgr.Text, sifregr.Password));
            if (client.giris(emailgr.Text, sifregr.Password) == "Giriş işlemi başarılı")
            {
                kullaniciemail = emailgr.Text;
                suankikullanici = 1;
                client.bilgigetir(emailgr.Text, ref kullaniciad, ref kullanicisoyad, ref kullanicisifre, ref kullanicitel);
                emailtab.Text = emailgr.Text;
                adtab.Text = kullaniciad;
                soyadtab.Text = kullanicisoyad;
                teltab.Text = kullanicitel.ToString();
                Giris.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "rsm/girilmismenu.jpg")));
                
                emailgr.Visibility = Visibility.Hidden;
                sifregr.Visibility = Visibility.Hidden;
                Girisyapbttn.Visibility = Visibility.Hidden;
                SifremiUnuttumBttn.Visibility = Visibility.Hidden;
                YeniUyeOlBttn.Visibility = Visibility.Hidden;
                uyeliksizalisverisbttn.Visibility = Visibility.Hidden;

            }



        }

        private void cikisbttn_Click(object sender, RoutedEventArgs e)
        {
            Giris.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "rsm/sagmenu.jpg")));
            cikisbttn.Visibility = Visibility.Visible;
            emailgr.Visibility = Visibility.Visible;
            sifregr.Visibility = Visibility.Visible;
            Girisyapbttn.Visibility = Visibility.Visible;
            SifremiUnuttumBttn.Visibility = Visibility.Visible;
            YeniUyeOlBttn.Visibility = Visibility.Visible;
            uyeliksizalisverisbttn.Visibility = Visibility.Visible;
            suankikullanici = 0;
        }

        private void urunaciklamasi_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < urunlist.Count; i++)
            {
                if (urunadi.Content.ToString() == urunlist.ElementAt(i).ad)
                {
                    messageboxurun messageboxurun = new messageboxurun() {
                     Background=   new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this),urunlist.ElementAt(i).urunaciklamasi))),
                    Width = urunlist.ElementAt(i).width,
                    Height = urunlist.ElementAt(i).height


                };
                    messageboxurun.Show();
                }
            }
            
            
        }

        private void cccheck_Click(object sender, RoutedEventArgs e)
        {
            int cb1ctrl = 0;
            if (cb1ctrl == 0)
            {
                cct1.Visibility = Visibility.Visible;
                cct2.Visibility = Visibility.Visible;
                cct3.Visibility = Visibility.Visible;
                cct4.Visibility = Visibility.Visible;
                cct5.Visibility = Visibility.Visible;
                cb1ctrl = 1;
            }
            else
            {
                cct1.Visibility = Visibility.Hidden;
                cct2.Visibility = Visibility.Hidden;
                cct3.Visibility = Visibility.Hidden;
                cct4.Visibility = Visibility.Hidden;
                cct5.Visibility = Visibility.Hidden;
                cb1ctrl = 0;
            }
        }

        private void havacheck_Click(object sender, RoutedEventArgs e)
        {
            int cb2ctrl = 0;
            if (cb2ctrl == 0)
            {
                havat1.Visibility = Visibility.Visible;
                cb2ctrl = 1;
            }
            else
            {
                havat1.Visibility = Visibility.Hidden;
                cb2ctrl = 0;
            }
            
        }

        private void sepettensil_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void finally_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Siparişiniz alınmıştır");
        }
    }
}
