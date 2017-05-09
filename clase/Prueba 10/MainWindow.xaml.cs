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

namespace Ej10R9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string num1 = String.Empty;
        char operacion = ' ';
        bool operador = false;
        public MainWindow()
        {
                InitializeComponent();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            MessageBoxResult salida = MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (salida == MessageBoxResult.OK)
                Application.Current.MainWindow.Close();
        }

        private void Anadir(object sender, RoutedEventArgs e)
        {
      
            if (operador)
            {
                operador = false;
                lbOperacion.Text =String.Empty;
            }
            if(lbOperacion.Text=="0")
            {
                lbOperacion.Text = String.Empty;
            }

            if ((string)(((Button)sender).Content) != "," && (string)(((Button)sender).Content) != "0")
            {
                lbOperacion.Text += ((Button)sender).Content;
            }
            else
            {
                if (lbOperacion.Text.Contains(","))
                {

                    if (lbOperacion.Text == "0" && (string)(((Button)sender).Content) == "0")
                    {
                        lbOperacion.Text += ((Button)sender).Content;
                        lbOperacion.Text = "0";
                    }
                }
                else
                {
                    if (lbOperacion.Text == String.Empty)
                    {
                        lbOperacion.Text = "0" + ((Button)sender).Content;
                    }
                    else 
                    {
                        lbOperacion.Text += ((Button)sender).Content;
                    }
                }
            }


        }

        private void BorrarOperacion(object sender, RoutedEventArgs e)
        {
            if (operacion != ' ')
            {
                operacion = ' ';
                lbOperacion.Text = num1;
            }

        }

        private void Operar(object sender, RoutedEventArgs e)
        {
            if (operacion == ' ')
            {
                num1 = lbOperacion.Text;
                lbOperacion.Text = "0";
                operacion = ((string)(((Button)sender).Content))[0];
            }
            else
            {
                Calcular(sender, e);
            }
        }

        private void Vaciar(object sender, RoutedEventArgs e)
        {
            num1 = String.Empty;
            operacion = ' ';
            lbOperacion.Text = "0";
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            if (operacion != ' ')
            {
                switch (operacion)
                {
                    case '+':
                        lbOperacion.Text = (double.Parse(num1) + double.Parse(lbOperacion.Text)).ToString();
                        num1 = lbOperacion.Text;
                        operacion = ' ';
                        break;
                    case '-':
                        lbOperacion.Text = (double.Parse(num1) - double.Parse(lbOperacion.Text)).ToString();
                        num1 = lbOperacion.Text;
                        operacion = ' ';
                        break;
                    case '*':
                        lbOperacion.Text = (double.Parse(num1) * double.Parse(lbOperacion.Text)).ToString();
                        num1 = lbOperacion.Text;
                        operacion = ' ';
                        break;
                    case '/':
                        if (lbOperacion.Text == "0")
                        {
                            MessageBox.Show("No es posible dividir entre 0", "Error");
                            return;
                        }
                        lbOperacion.Text = (double.Parse(num1) / double.Parse(lbOperacion.Text)).ToString();
                        num1 = lbOperacion.Text;
                        operacion = ' ';
                        break;

                    default:
                        break;
                }
                operador = true;
            }
         
        }

        private void Signo(object sender, RoutedEventArgs e)
        {
            lbOperacion.Text=(double.Parse(lbOperacion.Text)*-1).ToString();
        }

        private void Copiar(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(lbOperacion.Text);
        }

        private void Cortar(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(lbOperacion.Text);
            lbOperacion.Text = "0";
           
        }

        private void Pegar(object sender, RoutedEventArgs e)
        {
            double parse;
            try
            {
                
             double.TryParse( Clipboard.GetText(), out parse);
                if(parse!=0||Clipboard.GetText()=="0")
             lbOperacion.Text = lbOperacion.Text + parse.ToString();
            }
            catch { }
        }
    }
}
