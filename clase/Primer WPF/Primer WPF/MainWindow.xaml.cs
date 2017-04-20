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

namespace Primer_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Pillame si puedes. A Hideo Kojima Game");
            //while (true)
            //{
            //    Thickness pos = new Thickness(rectMueveme.Margin.Left, rectMueveme.Margin.Top, rectMueveme.Margin.Right, rectMueveme.Margin.Bottom);
            //    if ()
            //    {
            //        pos.Top++;
            //        rectMueveme.Margin = pos; 
            //    }
            //    if ()
            //    {
            //        pos.Top--;
            //        rectMueveme.Margin = pos;
            //    }
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Me han pulsado");
            //btnPulsame.Background = Brushes.Yellow;
        }

        private void btnPulsame_MouseEnter(object sender, MouseEventArgs e)
        {
            //Random alea = new Random();
            //btnPulsame.Content = "Nop";
            //btnPulsame.Margin = new Thickness(alea.Next(200), alea.Next(200), 0, 0);
        }

        private void btnPulsame_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            // MessageBox.Show("Tramposo");
        }

        private void rectMueveme_KeyDown(object sender, KeyEventArgs e)
        {
            //Thickness pos = new Thickness(rectMueveme.Margin.Left, rectMueveme.Margin.Top, rectMueveme.Margin.Right, rectMueveme.Margin.Bottom);
            //if (e.Key == Key.Up)
            //{
            //    pos.Top=pos.Top+10;
            //    rectMueveme.Margin = pos;
            //}
            //if (e.Key == Key.Down)
            //{
            //    pos.Top = pos.Top - 10;
            //    rectMueveme.Margin = pos;
            //}
        }


    }
}
