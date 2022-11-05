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

namespace Progetto1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreaBrano_Click(object sender, RoutedEventArgs e)
        {
            string autore = txtAutore.Text;
            string titolo = txtTitolo.Text;
            string durata = txtDurata.Text;
            Add.lblBrani.Content = "Autore: " + autore + "\nTitolo: " + titolo + "\nDurata: " + durata;
        }

    }
}
