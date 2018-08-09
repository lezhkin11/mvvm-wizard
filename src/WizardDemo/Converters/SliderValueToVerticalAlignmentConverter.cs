namespace WizardDemo.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// The slider value to vertical alignment converter.
    /// </summary>
    public class SliderValueToVerticalAlignmentConverter : IValueConverter
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly SliderValueToVerticalAlignmentConverter Instance =
            new SliderValueToVerticalAlignmentConverter();

        /// <summary>
        /// Prevents a default instance of the <see cref="SliderValueToVerticalAlignmentConverter"/> class from being created.
        /// </summary>
        private SliderValueToVerticalAlignmentConverter()
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
            if (value.Equals(0.0))
            {
                return VerticalAlignment.Top;
            }

            if (value.Equals(50.0))
            {
                return VerticalAlignment.Center;
            }

            if (value.Equals(100.0))
            {
                return VerticalAlignment.Bottom;
            }

            return DependencyProperty.UnsetValue;
        }
    }
}