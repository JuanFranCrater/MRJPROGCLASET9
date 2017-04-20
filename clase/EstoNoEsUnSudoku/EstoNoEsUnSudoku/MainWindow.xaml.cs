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

namespace EstoNoEsUnSudoku
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

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            LLenarGridAlea();
        }
        private void LLenarGridAlea()
        {
            List<int> listaNumeros = new List<int>(new int[]{1,2,3,4,5,6,7,8,9});
            Random rnd = new Random();
            int pos = 0;
            for (int i = 0; i < grdPanel.ColumnDefinitions.Count; i++)
            {
                for (int j = 0; j < grdPanel.RowDefinitions.Count; j++)
                {
                    pos = rnd.Next(listaNumeros.Count);
                    //Creo el objeto y asigno sus propiedades
                    TextBlock tbxTmp = new TextBlock();
                    tbxTmp.FontFamily = new FontFamily("Arial");
                    tbxTmp.FontSize = 75;
                    tbxTmp.VerticalAlignment = VerticalAlignment.Center;
                    tbxTmp.HorizontalAlignment = HorizontalAlignment.Center;
                    tbxTmp.Background = new SolidColorBrush(Colors.Aquamarine);
                    tbxTmp.Foreground = new SolidColorBrush(Colors.Red);
                    tbxTmp.Height = 80;
                    tbxTmp.Width = tbxTmp.Height;
                    tbxTmp.Text = listaNumeros[pos].ToString();
                    //Borro el valor entero asignado
                    listaNumeros.RemoveAt(pos);
                    //Asigno las posiciones al control dentro del Grid
                    Grid.SetRow(tbxTmp,i);
                    Grid.SetColumn(tbxTmp, j);
                    grdPanel.Children.Add(tbxTmp);

                }
            }
        }
    }
}
