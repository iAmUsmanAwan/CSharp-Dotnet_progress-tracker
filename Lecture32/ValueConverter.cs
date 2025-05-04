using System;
using System.Globalization;
using System.Windows.Data;

namespace Lecture32
{
    public class CheckStateToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? val = value?.ToString()?.ToLower().Trim();
            return val == "check";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;
            return isChecked ? "check" : "";
        }
    }

    public class UncheckStateToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? val = value?.ToString()?.ToLower().Trim();
            return val == "uncheck";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;
            return isChecked ? "uncheck" : "";
        }
    }
}
