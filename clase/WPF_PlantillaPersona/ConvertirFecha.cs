using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------
using System.Globalization;     // Para Culture
using System.Windows.Data;      // Para IValueConverter

namespace JuanF.Wpf_EnlacesDataContextAClases
{

    class ConvertirFecha:IValueConverter
    {
        int _dato = 0;
        public ConvertirFecha()
        {
            _dato = 10;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime fecha = (DateTime)value;
            return fecha.ToShortDateString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
