// ReSharper disable StyleCop.SA1600
namespace MvvmWizard.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// The wizard.
    /// </summary>
    public partial class Wizard
    {
        public static readonly DependencyProperty SummaryPanelTemplateProperty = DependencyProperty.Register(nameof(SummaryPanelTemplate), typeof(ItemsPanelTemplate), typeof(Wizard));
        public static readonly DependencyProperty SummaryVisibilityProperty = DependencyProperty.Register(nameof(SummaryVisibility), typeof(Visibility), typeof(Wizard), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty AllowNavigationOnSummaryItemClickProperty = DependencyProperty.Register(nameof(AllowNavigationOnSummaryItemClick), typeof(bool), typeof(Wizard));

        public static readonly DependencyProperty SummaryHorizontalAlignmentProperty = DependencyProperty.Register(nameof(SummaryHorizontalAlignment), typeof(HorizontalAlignment), typeof(Wizard), new PropertyMetadata(HorizontalAlignment.Center));
        public static readonly DependencyProperty SummaryVerticalAlignmentProperty = DependencyProperty.Register(nameof(SummaryVerticalAlignment), typeof(VerticalAlignment), typeof(Wizard), new PropertyMetadata(VerticalAlignment.Bottom));

        public static readonly DependencyProperty SummaryMarginProperty = DependencyProperty.Register(nameof(SummaryMargin), typeof(Thickness), typeof(Wizard));

        public ItemsPanelTemplate SummaryPanelTemplate
        {
            get { return (ItemsPanelTemplate)this.GetValue(SummaryPanelTemplateProperty); }
            set { this.SetValue(SummaryPanelTemplateProperty, value); }
        }

        public Visibility SummaryVisibility
        {
            get { return (Visibility)this.GetValue(SummaryVisibilityProperty); }
            set { this.SetValue(SummaryVisibilityProperty, value); }
        }

        public bool AllowNavigationOnSummaryItemClick
        {
            get { return (bool)this.GetValue(AllowNavigationOnSummaryItemClickProperty); }
            set { this.SetValue(AllowNavigationOnSummaryItemClickProperty, value); }
        }

        public HorizontalAlignment SummaryHorizontalAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(SummaryHorizontalAlignmentProperty); }
            set { this.SetValue(SummaryHorizontalAlignmentProperty, value); }
        }

        public VerticalAlignment SummaryVerticalAlignment
        {
            get { return (VerticalAlignment)this.GetValue(SummaryVerticalAlignmentProperty); }
            set { this.SetValue(SummaryVerticalAlignmentProperty, value); }
        }

        public Thickness SummaryMargin
        {
            get { return (Thickness)this.GetValue(SummaryMarginProperty); }
            set { this.SetValue(SummaryMarginProperty, value); }
        }
    }
}