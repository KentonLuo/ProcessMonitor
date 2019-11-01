using System;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Collections.Generic;


namespace ProcessMonitor.Converters
{
    /// <summary>
    /// Converts Collection to Visibility values.
    /// </summary>
    public class CollectionToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<object> items = value as IEnumerable<object>;
            if (null != items && items.Count<object>() > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
