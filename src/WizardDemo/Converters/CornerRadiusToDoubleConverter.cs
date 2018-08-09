namespace WizardDemo.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// The corner radius to double converter.
    /// </summary>
    public class CornerRadiusToDoubleConverter : IValueConverter
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly CornerRadiusToDoubleConverter Instance = new CornerRadiusToDoubleConverter();

        /// <summary>
        /// Prevents a default instance of the <see cref="CornerRadiusToDoubleConverter"/> class from being created.
        /// </summary>
        private CornerRadiusToDoubleConverter()
        {
        }

        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           throw new NotImplementedException();
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return DependencyProperty.UnsetValue;
            }

            return new CornerRadius((double)value);
        }
    }
}
