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

namespace WpfIntercambiodeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOrigen_Click(object sender, RoutedEventArgs e)
        {
            App objActual = Application.Current as App;
            if (objActual == null)
                return;
            objActual.Dato = tbxOrigen.Text;
            VentanaDestino venDestino = new VentanaDestino();
            venDestino.Show();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown(); //this.close() para cerrar solo una ventana. 
        }
        
    }
}
