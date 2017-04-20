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
using System.Windows.Threading;
using System.Threading;


namespace Balon_rebota
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer temporizador = new DispatcherTimer();
        int movx=1;
        int movy=1;
        int movx2 = 1;
        int movy2 = 1;
        public MainWindow()
        {
            temporizador.Tick +=Movimiento;
            InitializeComponent();
        }

        void Movimiento(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            Canvas.SetLeft(bola,Canvas.GetLeft(bola)+movx);
            Canvas.SetTop(bola, Canvas.GetTop(bola) + movy);
            Canvas.SetLeft(bola2, Canvas.GetLeft(bola2) + movx2);
            Canvas.SetTop(bola2, Canvas.GetTop(bola2) + movy2);
            if (Canvas.GetLeft(bola) == campo.Width-25 || Canvas.GetLeft(bola) == 0)
            {
                movx  = movx * -1;
            }
            if (Canvas.GetTop(bola) == campo.Height-25 || Canvas.GetTop(bola) == 0)
            {
                movy = movy * -1;
            }
            if (Canvas.GetLeft(bola2) == campo.Width - 25 || Canvas.GetLeft(bola2) == 0)
            {
                movx2 = movx2 * -1;
            }
            if (Canvas.GetTop(bola2) == campo.Height - 25 || Canvas.GetTop(bola2) == 0)
            {
                movy2 = movy2 * -1;
            }
            if (Math.Pow(Canvas.GetTop(bola) - Canvas.GetTop(bola2), 2) + Math.Pow(Canvas.GetLeft(bola) - Canvas.GetLeft(bola2), 2) <= Math.Pow((2 * 15), 2))
            {
                movx = movx * -1;
                movy = movy * -1;
                movx2 = movx2 * -1;
                movy2 = movy2 * -1;
            }

        }

        private void Pausa(object sender, RoutedEventArgs e)
        {

            if (temporizador.IsEnabled)
            {
                temporizador.Stop();
            btnInicio.Content = "Continuar";
            btnPausa.Content = "En Pausa";
            }
        }

        private void Inicio(object sender, RoutedEventArgs e)
        {
            
            if (!temporizador.IsEnabled)
            {
                temporizador.Start();
                btnInicio.Content = "En Movimiento";
                btnPausa.Content = "Pausar";
            }
              
        }

    }
}
