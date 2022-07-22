using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WPFBigExercise.Infrastructure
{
    class DataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tmp = (DateTime)value;
            return $"{DateTime.Now.Year - tmp.Year}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tmp = DateTime.Parse((string)value);
            return new DateTime(tmp.Year, tmp.Month, tmp.Day);
        }
    }
}
