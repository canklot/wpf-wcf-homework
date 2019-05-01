using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Takurunleri.xaml etkileşim mantığı
    /// </summary>
    public partial class Takurunleri : Page
    {
        public Takurunleri()
        {
            InitializeComponent();
        }

        private void Kaydir(string storyboardhide, StackPanel pnl)
        {
            Storyboard sb = Resources[storyboardhide] as Storyboard;
            sb.Begin(pnl);
        }
        private void urun1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Sayfa.Content = new acilanurun();
            Kaydir("urunpenceresiac", ((MainWindow)System.Windows.Application.Current.MainWindow).urunstackp);


            ((MainWindow)System.Windows.Application.Current.MainWindow).urunresm.Source = new BitmapImage(new Uri(((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(16).imagesource, UriKind.Relative));
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunadi.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(16).ad;
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunfiyati.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(16).fiyat;
        }

        private void urun2_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Sayfa.Content = new acilanurun();
            Kaydir("urunpenceresiac", ((MainWindow)System.Windows.Application.Current.MainWindow).urunstackp);


            ((MainWindow)System.Windows.Application.Current.MainWindow).urunresm.Source = new BitmapImage(new Uri(((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(17).imagesource, UriKind.Relative));
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunadi.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(17).ad;
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunfiyati.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(17).fiyat;
        }

        private void urun3_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Sayfa.Content = new acilanurun();
            Kaydir("urunpenceresiac", ((MainWindow)System.Windows.Application.Current.MainWindow).urunstackp);


            ((MainWindow)System.Windows.Application.Current.MainWindow).urunresm.Source = new BitmapImage(new Uri(((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(18).imagesource, UriKind.Relative));
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunadi.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(18).ad;
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunfiyati.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(18).fiyat;
        }

        private void urun4_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Sayfa.Content = new acilanurun();
            Kaydir("urunpenceresiac", ((MainWindow)System.Windows.Application.Current.MainWindow).urunstackp);


            ((MainWindow)System.Windows.Application.Current.MainWindow).urunresm.Source = new BitmapImage(new Uri(((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(19).imagesource, UriKind.Relative));
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunadi.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(19).ad;
            ((MainWindow)System.Windows.Application.Current.MainWindow).urunfiyati.Content = ((MainWindow)System.Windows.Application.Current.MainWindow).urunlist.ElementAt(19).fiyat;
        }
    }
}
