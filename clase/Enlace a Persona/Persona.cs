using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------
using System.ComponentModel;

namespace JuanF.Enlace_a_Persona
{
    public class Persona: INotifyPropertyChanged
    {
        string _nombre;
        string _apellido;
        DateTime _fechaNac;
        double _estatura;

        public string Nombre
        {
            get { return _nombre; }
            set {

                _nombre = value; MetodoAuxiliarCambio("Nombre");
            }
        }
       
        public string Apellido
        {
            get { return _apellido; }
            set {

                _apellido = value; MetodoAuxiliarCambio("Apellido");
            }
        }
       

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set
            {

                _fechaNac = value; MetodoAuxiliarCambio("FechaNac");
            }
        }
        public double Estatura
        {
            get { return _estatura; }
            set {

                _estatura = value; MetodoAuxiliarCambio("Estatura");
            }
        }

        public Persona()
        {
            _nombre = "Nombre";
            _apellido = "Apellido";
            _fechaNac = DateTime.Now;
            _estatura = 0.0;
        
        }
        public Persona(string nombre,string apellido, DateTime fechaNacimiento, double estatura)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNac = fechaNacimiento;
            _estatura = estatura;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void MetodoAuxiliarCambio(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}
