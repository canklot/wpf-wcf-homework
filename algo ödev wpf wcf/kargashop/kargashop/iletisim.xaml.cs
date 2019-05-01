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




namespace kargashop
{
    /// <summary>
    /// iletisim.xaml etkileşim mantığı
    /// </summary>
    public partial class iletisim : Page
    {
        public iletisim()
        {
            InitializeComponent();
            
            
        }

        private void iletisimfrmbtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Sayfa.Content = new Iletisimformu();
            
        }
    }
}
