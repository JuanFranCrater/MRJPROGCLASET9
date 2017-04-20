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

namespace ButtonsTry
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

        private void Arriba(object sender, RoutedEventArgs e)
        {
            Thickness pos = caja.Margin;
            pos.Top = pos.Top - 10;
            caja.Margin = pos;

        }

        private void Izquierda(object sender, RoutedEventArgs e)
        {
            Thickness pos = caja.Margin;
            pos.Left = pos.Left - 10;
            caja.Margin = pos;
        }

        private void Derecha(object sender, RoutedEventArgs e)
        {
            Thickness pos = caja.Margin;
            pos.Left = pos.Left + 10;
            caja.Margin = pos;
        }

        private void Abajo(object sender, RoutedEventArgs e)
        {
            Thickness pos = caja.Margin;
            pos.Top = pos.Top + 10;
            caja.Margin = pos;
        }
    }
}
