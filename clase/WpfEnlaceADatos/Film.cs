using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnlaceADatos
{
    public enum Genero 
    { 
    Mafia, Drama, Catastrofismo, Aventuras, Comedia, Oeste, CienciaFiccion, Romance, Historico, Belico    };
    class Film
    {
        string _titulo;
        string _director;
        Genero _genero;
        bool? _oscar;
        double _calificacion;
        public Film(string titulo, string director, Genero genero, bool? oscar, double calificacion)
        {
            _titulo = titulo;
            _director = director;
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
            set { _titulo = value; }
        }
        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }
        public Genero Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public bool? Oscar
        {
            get { return _oscar; }
            set { _oscar = value; }
        }
        public double Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }
    }
}
