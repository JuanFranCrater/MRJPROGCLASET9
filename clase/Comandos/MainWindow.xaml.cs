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

namespace Comandos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer reloj = new DispatcherTimer();
        int contador = 0;
        public MainWindow()
        {
            reloj.Tick += reloj_Tick;
            reloj.Start();
            
            InitializeComponent();
        }

        void reloj_Tick(object sender, EventArgs e)
        {
            contador++;
            RotateTransform rotacion = new RotateTransform(contador);
            hola.RenderTransform = rotacion;

        }
    }
}
