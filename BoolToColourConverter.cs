using System;
using System.Globalization;
using Xamarin.Forms;


namespace PCLToolKit
{
    public class BoolToColourConverter : IValueConverter    
    {
        public Color TrueColour { get; set; }
        public Color FalseColour { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? TrueColour : FalseColour;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
