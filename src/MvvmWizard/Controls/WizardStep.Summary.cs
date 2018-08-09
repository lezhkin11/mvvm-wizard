// --------------------------------------------------------------------------------------------------------------------
// ReSharper disable StyleCop.SA1600
namespace MvvmWizard.Controls
{
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// The wizard step.
    /// </summary>
    public partial class WizardStep
    {
        public static readonly DependencyProperty SummaryItemWidthProperty = DependencyProperty.Register(nameof(SummaryItemWidth), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty SummaryItemHeightProperty = DependencyProperty.Register(nameof(SummaryItemHeight), typeof(double), typeof(WizardStep));

        public static readonly DependencyProperty ActiveSummaryItemWidthProperty = DependencyProperty.Register(nameof(ActiveSummaryItemWidth), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty ActiveSummaryItemHeightProperty = DependencyProperty.Register(nameof(ActiveSummaryItemHeight), typeof(double), typeof(WizardStep));

        public static readonly DependencyProperty SummaryItemBrushProperty = DependencyProperty.Register(nameof(SummaryItemBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty ProcessedSummaryItemBrushProperty = DependencyProperty.Register(nameof(ProcessedSummaryItemBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty ActiveSummaryItemBrushProperty = DependencyProperty.Register(nameof(ActiveSummaryItemBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty SummaryItemMouseOverBrushProperty = DependencyProperty.Register(nameof(SummaryItemMouseOverBrush), typeof(Brush), typeof(WizardStep));

        public double SummaryItemWidth
        {
            get { return (double)this.GetValue(SummaryItemWidthProperty); }
            set { this.SetValue(SummaryItemWidthProperty, value); }
        }

        public double SummaryItemHeight
        {
            get { return (double)this.GetValue(SummaryItemHeightProperty); }
            set { this.SetValue(SummaryItemHeightProperty, value); }
        }

        public double ActiveSummaryItemWidth
        {
            get { return (double)this.GetValue(ActiveSummaryItemWidthProperty); }
            set { this.SetValue(ActiveSummaryItemWidthProperty, value); }
        }

        public double ActiveSummaryItemHeight
        {
            get { return (double)this.GetValue(ActiveSummaryItemHeightProperty); }
            set { this.SetValue(ActiveSummaryItemHeightProperty, value); }
        }

        public Brush SummaryItemBrush
        {
            get { return (Brush)this.GetValue(SummaryItemBrushProperty); }
            set { this.SetValue(SummaryItemBrushProperty, value); }
        }

        public Brush ProcessedSummaryItemBrush
        {
            get { return (Brush)this.GetValue(ProcessedSummaryItemBrushProperty); }
            set { this.SetValue(ProcessedSummaryItemBrushProperty, value); }
        }

        public Brush ActiveSummaryItemBrush
        {
            get { return (Brush)this.GetValue(ActiveSummaryItemBrushProperty); }
            set { this.SetValue(ActiveSummaryItemBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the brush for the item when: <para></para>
        ///   <see cref="IsSelected"/> = <see langword="false" />
        ///  AND
        ///   <see cref="UIElement.IsMouseOver"/> = <see langword="true" />
        /// </summary>
        public Brush SummaryItemMouseOverBrush
        {
            get { return (Brush)this.GetValue(SummaryItemMouseOverBrushProperty); }
            set { this.SetValue(SummaryItemMouseOverBrushProperty, value); }
        }
    }
}