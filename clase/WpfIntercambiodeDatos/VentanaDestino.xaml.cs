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

namespace WpfIntercambiodeDatos
{
    /// <summary>
    /// Lógica de interacción para VentanaDestino.xaml
    /// </summary>
    public partial class VentanaDestino : Window
    {
        public VentanaDestino()
        {
            InitializeComponent();
        }

        private void btnOrigen_Click(object sender, RoutedEventArgs e)
        {
            tbxDestino.Text = (Application.Current as App).Dato;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tbxDestino.Text = (Application.Current as App).Dato;
        }
    }
}
