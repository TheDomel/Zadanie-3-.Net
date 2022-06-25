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

namespace Zadanie_3.Net
{

    public partial class MainWindow : Window
    {
        Dane dane = new Dane();
        public MainWindow()
        {
            DataContext = dane;
            InitializeComponent();
        }

        private void Edytuj(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)FindName("Albumy");
            Album album = (Album)lista.SelectedItem;
            new Edycja(album).Show();

        }
        private void Dodaj(object sender, RoutedEventArgs e)
        {
            new Edycja(dane.Nowy()).Show();
        }
    }
}