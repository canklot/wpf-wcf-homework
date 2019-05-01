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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kargashop.ServiceReference1;

namespace kargashop
{
    /// <summary>
    /// Yeniuyeol.xaml etkileşim mantığı
    /// </summary>
    public partial class Yeniuyeol : Page
    {
        Service1Client client = new Service1Client();
        public Yeniuyeol()
        {
            
            InitializeComponent();
            guvenlikl.Content = client.guvenlikkodugndr().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (guvenlikl.Content.ToString() != guvenlikt.Text.ToString())
                {
                    System.Windows.MessageBox.Show("Güvenlik kodunu doğru giriniz");
                }
                else
                {
                    System.Windows.MessageBox.Show(client.kayitol(adt.Text, soyadt.Text, sifret.Text, sifretekrart.Text, Convert.ToInt64(ceptelt.Text), emailt.Text
                    ));
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Cep telefonunuzu doğru giriniz");
            }

        }
    }
}
