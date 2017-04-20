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
using System.IO;

namespace Grid
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

        private void Cambiar4(object sender, RoutedEventArgs e)
        {
            Imagen.Source = new BitmapImage(new Uri(@"D:\Usuario\Escritorio\Grid\Grid\Imagenes\Desert.jpg"));
            Texto.Content = System.IO.Path.GetFileName(Imagen.Source.ToString());
        }

        private void Cambiar1(object sender, RoutedEventArgs e)
        {
            Imagen.Source = new BitmapImage(new Uri(@"D:\Usuario\Escritorio\Grid\Grid\Imagenes\Chrysanthemum.jpg"));
            Texto.Content = System.IO.Path.GetFileName(Imagen.Source.ToString());
        }

        private void Cambiar2(object sender, RoutedEventArgs e)
        {
            Imagen.Source = new BitmapImage(new Uri(@"D:\Usuario\Escritorio\Grid\Grid\Imagenes\Lighthouse.jpg"));
            Texto.Content = System.IO.Path.GetFileName(Imagen.Source.ToString());
        }

        private void Cambiar3(object sender, RoutedEventArgs e)
        {
            Imagen.Source = new BitmapImage(new Uri(@"D:\Usuario\Escritorio\Grid\Grid\Imagenes\Koala.jpg"));
            Texto.Content = System.IO.Path.GetFileName(Imagen.Source.ToString());
        }
    }
}
