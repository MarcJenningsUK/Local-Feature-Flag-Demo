using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace FeatureControl
{
    public class FeatureToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is string)
            {
                return FeatureManager.IsFeatureEnabled(parameter.ToString()) ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
