using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------
using System.Collections.ObjectModel;//ObservableColletion<>

namespace JuanF.Enlace_a_Persona
{
    class ListaPersonas:ObservableCollection<Persona>
    {
        Random rnd = new Random();

        //Creo una lista con varias personas

        public ListaPersonas(): base()
        {
            Add(new Persona("Pepe", "Rodriguez", CrearFechacimiento(), CrearEstatura())); 
            Add(new Persona("Rick", "Sanchez", CrearFechacimiento(), CrearEstatura()));
            Add(new Persona("Pepe", "Martinez", CrearFechacimiento(), CrearEstatura()));
            Add(new Persona("Jose", "Rodriguez", CrearFechacimiento(), CrearEstatura()));
            Add(new Persona("Pepito", "Grillo", CrearFechacimiento(), CrearEstatura())); 
            Add(new Persona("Platanito", "Crack", CrearFechacimiento(), CrearEstatura()));
        }

        private DateTime CrearFechacimiento()
        {
            //Crea una fecha aleatoria
            DateTime fechatmp = new DateTime();
            fechatmp = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 30));
            return fechatmp;
        }
        private double CrearEstatura()
        {
            double estatura;
            estatura = rnd.Next(150, 211);
                estatura=estatura/100;
            return estatura;
        }
    }
}
