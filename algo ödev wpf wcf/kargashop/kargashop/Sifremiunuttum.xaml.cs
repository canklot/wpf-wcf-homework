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
using kargashop.ServiceReference1;
using System.Windows.Shapes;

namespace kargashop
{
    /// <summary>
    /// Sifremiunuttum.xaml etkileşim mantığı
    /// </summary>
    public partial class Sifremiunuttum : Page
    {
        Service1Client client = new Service1Client();
        public Sifremiunuttum()
        {
            InitializeComponent();
            guvenlikl.Content = client.guvenlikkodugndr().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (guvenlikt.Text == guvenlikl.Content.ToString())
                {
                    System.Windows.MessageBox.Show(client.sifremiunuttum(emailte.Text));
                   
                }
                else { System.Windows.MessageBox.Show("Güvenlik kodunu yanlış girdiniz"); }
            
            }
            catch
            {
                System.Windows.MessageBox.Show("Güvenlik kodunu yanlış girdiniz");
            }
        }

        private void emailte_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
