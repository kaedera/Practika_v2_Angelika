using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static Practika_v2_Angelika.Pages.StatusZakazaBD;

namespace Practika_v2_Angelika.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZakazyBD.xaml
    /// </summary>
    public partial class ZakazyBD : Page
    {
        public ObservableCollection<Order> Orders { get; set; }
        public ZakazyBD()
        {
            InitializeComponent();
            Orders = new ObservableCollection<Order>();
            dataGrid.ItemsSource = Orders;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Orders.Add(new Order());
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                // Реализация редактирования
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                Orders.Remove((Order)dataGrid.SelectedItem);
            }
        }
        public class Order
        {
            public int IdZakaza { get; set; } = 0;
            public int IdClienta { get; set; } = 0;
            public string DataZakaza { get; set; }
            public double Summa { get; set; }
            public int IdPizzy { get; set; } = 0;
            public int IdAkcii { get; set; } = 0;
            public int Kolichestvo { get; set; } = 0;
        }
    }
}

