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
using System.Windows.Shapes;

namespace Zadanie_3.Net
{
    /// <summary>
    /// Logika interakcji dla klasy Edycja.xaml
    /// </summary>
    public partial class Edycja : Window
    {
        public Edycja(Album album)
        {
            DataContext = album;
            InitializeComponent();
        }

        private void Zatwierdź(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
