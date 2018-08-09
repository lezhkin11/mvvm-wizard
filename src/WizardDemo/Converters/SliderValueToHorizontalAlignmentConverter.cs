namespace WizardDemo.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// The slider value to horizontal alignment converter.
    /// </summary>
    public class SliderValueToHorizontalAlignmentConverter : IValueConverter
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly SliderValueToHorizontalAlignmentConverter Instance =
            new SliderValueToHorizontalAlignmentConverter();

        /// <summary>
        /// Prevents a default instance of the <see cref="SliderValueToHorizontalAlignmentConverter"/> class from being created.
        /// </summary>
        private SliderValueToHorizontalAlignmentConverter()
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
                return HorizontalAlignment.Left;
            }

            if (value.Equals(50.0))
            {
                return HorizontalAlignment.Center;
            }

            if (value.Equals(100.0))
            {
                return HorizontalAlignment.Right;
            }

            return DependencyProperty.UnsetValue;
        }
    }
}