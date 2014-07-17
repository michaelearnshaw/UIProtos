using System;
using System.Windows.Media;
using System.Windows.Data;

namespace Laminar.UI.IGTest
{
    public class QuantityToColorConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return Binding.DoNothing;

            if (value is int)
            {
                var temp = (int)value;

                if(temp<0)
                {
                    return Colors.Red;
                }
                else    
                {
                    return Colors.Blue;
                }
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
