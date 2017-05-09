using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace WpfEnlaceADatos
{
    public enum Genero 
    { 
    Mafia, Drama, Catastrofismo, Aventuras, Comedia, Oeste, CienciaFiccion, Romance, Historico, Belico    };

    /// <summary>
    /// Clase usada para propagar/ informar de los cambios de propiedades
    /// </summary>
    public class Notificador : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Codificacion del metodo controlador eventos

        protected void OnPropertyChanged(string nombrePropiedad)
        { 
                if(PropertyChanged !=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
                }
        }
    }

    class Film : Notificador
    {
        string _titulo;
        Genero _genero;
        bool? _oscar;
        double _calificacion;
        ObservableCollection<string> _actores = new ObservableCollection<string> { };
        Director _director;

        public Director Director
        {
            get { return _director; }
            set { _director = value; }
        }

        public ObservableCollection<string> Actores
        {
            get { return _actores; }
            set { _actores = value; }
        }

        public Film(string titulo, Genero genero, bool? oscar, double calificacion)
        {
            _titulo = titulo;
            _genero = genero;
            _oscar = oscar;
            _calificacion = calificacion;
        }
        public Film()
        {
        
        }
        public string Titulo
        {
            get { return _titulo; }
            set 
            {
                if (_titulo != value)
                {
                    _titulo = value;
                    OnPropertyChanged("Titulo");
                }
                
            }
        }
        public Genero Genero
        {
            get { return _genero; }
            set
            {
                if (_genero != value)
                {
                    _genero = value;
                    OnPropertyChanged("Genero");
                }
            }
        }
        public bool? Oscar
        {
            get { return _oscar; }
            set
            {
                if (_oscar != value)
                {
                    _oscar = value;
                    OnPropertyChanged("Oscar");
                }
            }
        }
        public double Calificacion
        {
            get { return _calificacion; }
            set
            {
                if (_calificacion != value)
                {
                    _calificacion = value;
                    OnPropertyChanged("Calificacion");
                }
            }
        }
    }
}
