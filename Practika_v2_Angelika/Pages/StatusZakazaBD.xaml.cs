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

namespace Practika_v2_Angelika.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatusZakazaBD.xaml
    /// </summary>
    public partial class StatusZakazaBD : Page

    {
        public ObservableCollection<DataItem> DataItems { get; set; }
        public StatusZakazaBD()
        {
            InitializeComponent();
            DataItems = new ObservableCollection<DataItem>();
            dataGrid.ItemsSource = DataItems;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataItems.Add(new DataItem());
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                // Implement edit functionality
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                DataItems.Remove((DataItem)dataGrid.SelectedItem);
            }
        }
        public class DataItem
        {
            public int id_upravleniya { get; set; } = 0;
            public int id_sotrudnika { get; set; } = 0;
            public int id_zakaza { get; set; } = 0;
            public int id_statusa { get; set; } = 0;
        }
    }
}
