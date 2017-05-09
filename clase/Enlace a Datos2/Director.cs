using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace WpfEnlaceADatos
{
    public class Director : Notificador
    {
        ObservableCollection<Film> _filmografia;

        public ObservableCollection<Film> Filmografia
        {
            get { return _filmografia; }
            set { _filmografia = value; }
        }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public Director()
        {
            _filmografia = new ObservableCollection<Film>();
        }

    }
}
