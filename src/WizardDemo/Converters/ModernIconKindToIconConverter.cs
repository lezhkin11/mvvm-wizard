namespace WizardDemo.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    using MahApps.Metro.IconPacks;

    /// <summary>
    /// The modern icon kind to icon converter.
    /// </summary>
    public class ModernIconKindToIconConverter : IValueConverter
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly ModernIconKindToIconConverter Instance = new ModernIconKindToIconConverter();

        /// <summary>
        /// The thickness converter.
        /// </summary>
        private readonly ThicknessConverter thicknessConverter;

        /// <summary>
        /// Prevents a default instance of the <see cref="ModernIconKindToIconConverter"/> class from being created.
        /// </summary>
        private ModernIconKindToIconConverter()
        {
            this.thicknessConverter = new ThicknessConverter();
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
                return null;
            }
           
            var margin = (Thickness)this.thicknessConverter.ConvertFrom(parameter);

            var kind = (PackIconModernKind)value;

            return new PackIconModern
                       {
                           Kind = kind,
                           Margin = margin,
                       };
        }
    }
}