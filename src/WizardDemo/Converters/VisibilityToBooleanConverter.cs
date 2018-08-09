namespace WizardDemo.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// The visibility to boolean converter.
    /// </summary>
    public class VisibilityToBooleanConverter : IValueConverter
    {
        /// <summary>
        ///  The singleton instance.
        /// </summary>
        public static readonly VisibilityToBooleanConverter Instance = new VisibilityToBooleanConverter();

        /// <summary>
        /// Prevents a default instance of the <see cref="VisibilityToBooleanConverter"/> class from being created.
        /// </summary>
        private VisibilityToBooleanConverter()
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
            return value.Equals(true) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}