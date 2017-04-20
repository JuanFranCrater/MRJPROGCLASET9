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
using System.Threading;

namespace Identificate
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string CLAVE = "12345";
        const string USUARIO = "USUARIO";
        string clave;
        string usuario;
        int numIntentos = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Aceptar(object sender, RoutedEventArgs e)
        {
            usuario = tbxUsu.Text;
            clave = tbxclave.Password;
            numIntentos++;
            if (numIntentos >= 3)
            {
                MessageBox.Show("Demasiados intentos");
                this.Close();
            }
            if (USUARIO == usuario)
            {
                if (CLAVE == clave)
                { new Bienvenido().ShowDialog(); }
                else
                {
                    MessageBox.Show("Wrong.Try again");
                }
            }
            
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {

        }
    }
}
