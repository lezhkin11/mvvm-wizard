namespace WizardDemo.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// The thickness to double converter.
    /// </summary>
    public class ThicknessToDoubleConverter : IValueConverter
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly ThicknessToDoubleConverter Instance = new ThicknessToDoubleConverter();

        /// <summary>
        /// Prevents a default instance of the <see cref="ThicknessToDoubleConverter"/> class from being created.
        /// </summary>
        private ThicknessToDoubleConverter()
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

            return new Thickness((double)value);
        }
    }
}
