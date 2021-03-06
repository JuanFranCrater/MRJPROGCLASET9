﻿using System;
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
//---------
using JuanF.Wpf_EnlacesDataContextAClases;

namespace WPF_PlantillaPersona
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaPersonas _listaPersonas = null;
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
            _listaPersonas = new ListaPersonas();
            grdDatos.DataContext = _listaPersonas;
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Persona tmpPersona = _listaPersonas[contador++%_listaPersonas.Count];
            grdDatos.DataContext = tmpPersona;
        }
    }
}
