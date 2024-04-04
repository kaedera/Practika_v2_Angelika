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
using static Practika_v2_Angelika.Pages.ZakazyBD;

namespace Practika_v2_Angelika.Pages
{
    /// <summary>
    /// Логика взаимодействия для DostavkaBD.xaml
    /// </summary>
    public partial class DostavkaBD : Page
    {
        public ObservableCollection<Dostavki> Dostavkis { get; set; }
        public DostavkaBD()
        {
            InitializeComponent();
            Dostavkis = new ObservableCollection<Dostavki>();
            dataGrid.ItemsSource = Dostavkis;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Dostavkis.Add(new Dostavki());
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
                Dostavkis.Remove((Dostavki)dataGrid.SelectedItem);
            }
        }
        public class Dostavki
        {
            public int id_raspisaniya { get; set; } = 0;
            public int id_zakaza { get; set; } = 0;
            public int id_kurera { get; set; } = 0;
            public string data_dostavki { get; set; } 
            public string vremya_dostavki { get; set; } 

        }
    }
}
