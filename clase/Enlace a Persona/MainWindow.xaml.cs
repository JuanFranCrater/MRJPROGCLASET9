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
//---------------------------------
using JuanF.Enlace_a_Persona;

namespace Enlace_a_Persona
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona persona = null;
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            //Poner el contexto de datos al Grid
            persona = new Persona();
            GridDAtos.DataContext = persona;
        }

        private void btnOtraPersona_Click(object sender, RoutedEventArgs e)
        {
            //Obtiene una persona aleatoriamente

            persona = new ListaPersonas()[rnd.Next(new ListaPersonas().Count)];
            GridDAtos.DataContext = persona;
        }

        private void btnCambiaNombre_Click(object sender, RoutedEventArgs e)
        {
            persona.Nombre = "Eliseo";
        }
    }
}
