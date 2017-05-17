using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------
using System.Globalization;     // Para Culture
using System.Windows.Data;      // Para IValueConverter

namespace Wpf_EnlacesDataContextAClases.Imagenes
{
    class ConvertirFecha:IValueConverter
    {
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
