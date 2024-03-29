using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp7.Model
{
    internal class DecimalToEuroConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert the decimal value to a string with euro sign
            var euroCulture = CultureInfo.GetCultureInfo("nl-NL");
            // Convert the decimal value to a string with euro sign
            return ((decimal)value).ToString("C", euroCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
