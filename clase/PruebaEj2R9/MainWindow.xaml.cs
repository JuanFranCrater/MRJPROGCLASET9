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

namespace Ej2R9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Exception ExpresionMalFormadaExcepcion = new Exception("Es posible que la expresion no sea correcta. Vuelva a escribirla.\nRecuerde no introducir letras, caracteres raros o dos operadores seguidos.");

        public MainWindow()
        {
            InitializeComponent();
        }
        double Suma(double num1, double num2)
        {
            return num1 + num2;
        }
        double Resta(double num1, double num2)
        {
            return num1 - num2;
        }
        double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }
        double Division(double num1, double num2)
        {
            if (num2==0)
                throw ExpresionMalFormadaExcepcion;
            return num1 / num2;
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            List<double> numeros = new List<double> { };
            string numtmp = string.Empty;
            int numtemp;
            List<char> operaciones = new List<char> { };
            try
            {
                for (int i = 0; i < textBox.Text.Length; i++)
                {
                    if (int.TryParse(textBox.Text[i].ToString(), out numtemp))
                    {
                        numtmp = numtmp + numtemp.ToString();
                    }
                    else
                    {
                        if (i != 1 && (textBox.Text[i] == '.' || textBox.Text[i] == ','))
                        { numtmp = numtmp + numtemp.ToString(); }
                        if (numtmp == string.Empty)
                        {
                            throw ExpresionMalFormadaExcepcion;
                        }
                        switch (textBox.Text[i])
                        {
                            case '+':
                                operaciones.Add(textBox.Text[i]);
                                break;
                            case '-':
                                operaciones.Add(textBox.Text[i]);
                                break;
                            case '*':
                                operaciones.Add(textBox.Text[i]);
                                break;
                            case '/':
                                operaciones.Add(textBox.Text[i]);
                                break;

                            default:
                                throw ExpresionMalFormadaExcepcion;
                        }
                        numeros.Add(double.Parse(numtmp));
                        numtmp = string.Empty;
                    }
                }
                numeros.Add(double.Parse(numtmp));
                numtmp = string.Empty;
                if (operaciones.Count >= numeros.Count)
                { throw ExpresionMalFormadaExcepcion; }
                for (int i = 0; i < operaciones.Count; i++)
                {
                    switch (operaciones[i])
                    {
                        case '+':
                            numeros[i + 1] = Suma(numeros[i], numeros[i + 1]);
                            break;
                        case '-':
                            numeros[i + 1] = Resta(numeros[i], numeros[i + 1]);
                            break;
                        case '*':
                            numeros[i + 1] = Multiplicacion(numeros[i], numeros[i + 1]);
                            break;
                        case '/':
                            numeros[i + 1] = Division(numeros[i], numeros[i + 1]);
                            break;

                        default:
                            throw ExpresionMalFormadaExcepcion;
                    }
                }
                label.Content = numeros[numeros.Count - 1];
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Error");
            }
        }

        private void Vaciar(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
        }
    }
}