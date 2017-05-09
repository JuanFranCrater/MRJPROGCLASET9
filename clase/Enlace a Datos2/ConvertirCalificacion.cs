using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------
using System.Windows.Data;
using System.Globalization;//espacio nombre de culture info

namespace Enlace_a_Datos2
{
    [ValueConversion(typeof(double), typeof(string))]
    public class ConvertirCalificacion: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Converte la calificacion (double) en letra (string)

            string[] valoresLetras = { "Cero","Uno", "Dos", "Tres", "Cuatro", "Cinco, maquina, crack, Figura" };
            //Comprobaciones previas

            if (targetType == typeof(string) && value.GetType() == typeof(double))
            {
                return valoresLetras[(int)Math.Round((double)value)];
            }
            else 
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Método ConvertBack no esta codificado, codifica tonto");
        }
    }
}
