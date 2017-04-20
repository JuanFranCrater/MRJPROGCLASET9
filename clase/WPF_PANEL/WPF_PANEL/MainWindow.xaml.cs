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

namespace WPF_PANEL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int contador;
        string[] sources = new string[] { @"D:\Usuario\Escritorio\Imagenes\Chrysanthemum.jpg", @"D:\Usuario\Escritorio\Imagenes\Lighthouse.jpg", @"D:\Usuario\Escritorio\Imagenes\Hydrangeas.jpg", @"D:\Usuario\Escritorio\Imagenes\Jellyfish.jpg", @"D:\Usuario\Escritorio\Imagenes\Desert.jpg", @"D:\Usuario\Escritorio\Imagenes\Koala.jpg" };
        public MainWindow()
        {
            InitializeComponent();
            contador = 0;
            BitmapImage imagen = new BitmapImage(new Uri(@"D:\Usuario\Escritorio\Imagenes\Chrysanthemum.jpg"));
            muestra.Source = imagen;
           
        }


        private void BotonFotoAnterior(object sender, RoutedEventArgs e)
        {

            if (contador == 0)
            {
                contador = 5;
                BitmapImage imagen = new BitmapImage(new Uri(sources[contador]));
                muestra.Source = imagen;
                return;
            }
            contador--;
            BitmapImage imagen2 = new BitmapImage(new Uri(sources[contador]));
            muestra.Source = imagen2;  
        }

        private void BotonFotoPosterior(object sender, RoutedEventArgs e)
        {
           

                    if (contador == 5)
                    {
                        contador=0;
                        BitmapImage imagen = new BitmapImage(new Uri(sources[contador]));
                        muestra.Source = imagen;
                        return;
                    }
                    contador++;
                    BitmapImage imagen2 = new BitmapImage(new Uri(sources[contador]));
                    muestra.Source = imagen2; 
            
        }
    }
}
