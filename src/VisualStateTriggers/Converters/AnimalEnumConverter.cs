using System;
using System.Globalization;
using VisualStateTriggers.Models;
using Xamarin.Forms;

namespace VisualStateTriggers.Converters
{
    public class AnimalEnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is AnimalType selected && parameter is AnimalType target && selected == target);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
