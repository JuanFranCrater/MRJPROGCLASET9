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

namespace Canvas
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
        private Brush PickBrush()
        {
            Brush result = Brushes.Transparent;

            Random rnd = new Random();

            Type brushesType = typeof(Brushes);

            System.Reflection.PropertyInfo[] properties= brushesType.GetProperties();

            int random = rnd.Next(properties.Length);
            result = (Brush)properties[random].GetValue(null, null);

            return result;
        }

        private void BotonToXulo(object sender, RoutedEventArgs e)
        {
                N1.Background = PickBrush();
                N2.Background = PickBrush();
                N3.Background = PickBrush();
                N4.Background = PickBrush();
                N5.Background = PickBrush();
                N6.Background = PickBrush();
                N7.Background = PickBrush();
                N8.Background = PickBrush();
                N9.Background = PickBrush();
                N10.Background = PickBrush();
                N11.Background = PickBrush();
                N12.Background = PickBrush();
                N13.Background = PickBrush();
                N14.Background = PickBrush();
                N15.Background = PickBrush();
        }
    }
}
