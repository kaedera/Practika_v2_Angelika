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

namespace Practika_v2_Angelika.Pages
{
    /// <summary>
    /// Логика взаимодействия для Rabotnik.xaml
    /// </summary>
    public partial class Rabotnik : Page
    {
        public Rabotnik()
        {
            InitializeComponent();
        }

        private void btnZakazy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ZakazyBD());
        }

        private void btnDostavka_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DostavkaBD());
        }

        private void btnStatusZakaza_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StatusZakazaBD());
        }
    }
}
