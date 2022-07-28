using System;
using System.Globalization;
using System.Windows.Data;

namespace Curencies.ValueConverters
{
    internal class CurencyValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal val = (decimal)value;
            return val.ToString("0.00€");

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
