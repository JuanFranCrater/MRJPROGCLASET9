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
//....
using System.ComponentModel;

namespace SortList
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

        private void Ordenar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Lista.Items.SortDescriptions.Clear();

            if (Ordenar.SelectedIndex == 0)
            { Lista.Items.SortDescriptions.Add(new SortDescription("Text", ListSortDirection.Ascending)); }
            else
            { Lista.Items.SortDescriptions.Add(new SortDescription("TExt", ListSortDirection.Descending)); }
        }

    }
}
