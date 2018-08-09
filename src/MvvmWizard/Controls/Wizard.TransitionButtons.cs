// ReSharper disable StyleCop.SA1600
namespace MvvmWizard.Controls
{
    using System.Windows;

    /// <summary>
    /// The wizard.
    /// </summary>
    public partial class Wizard
    {
        public static readonly DependencyProperty TransitionButtonsVerticalAlignmentProperty = DependencyProperty.Register(nameof(TransitionButtonsVerticalAlignment), typeof(VerticalAlignment), typeof(Wizard), new PropertyMetadata(VerticalAlignment.Bottom));
        public static readonly DependencyProperty TransitionButtonsHorizontalAlignmentProperty = DependencyProperty.Register(nameof(TransitionButtonsHorizontalAlignment), typeof(HorizontalAlignment), typeof(Wizard), new PropertyMetadata(HorizontalAlignment.Right));

        public static readonly DependencyProperty BackButtonStyleProperty = DependencyProperty.Register(nameof(BackButtonStyle), typeof(Style), typeof(Wizard));
        public static readonly DependencyProperty SkipButtonStyleProperty = DependencyProperty.Register(nameof(SkipButtonStyle), typeof(Style), typeof(Wizard));
        public static readonly DependencyProperty ForwardButtonStyleProperty = DependencyProperty.Register(nameof(ForwardButtonStyle), typeof(Style), typeof(Wizard));

        public VerticalAlignment TransitionButtonsVerticalAlignment
        {
            get { return (VerticalAlignment)this.GetValue(TransitionButtonsVerticalAlignmentProperty); }
            set { this.SetValue(TransitionButtonsVerticalAlignmentProperty, value); }
        }

        public HorizontalAlignment TransitionButtonsHorizontalAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(TransitionButtonsHorizontalAlignmentProperty); }
            set { this.SetValue(TransitionButtonsHorizontalAlignmentProperty, value); }
        }

        public Style BackButtonStyle
        {
            get { return (Style)this.GetValue(BackButtonStyleProperty); }
            set { this.SetValue(BackButtonStyleProperty, value); }
        }

        public Style SkipButtonStyle
        {
            get { return (Style)this.GetValue(SkipButtonStyleProperty); }
            set { this.SetValue(SkipButtonStyleProperty, value); }
        }

        public Style ForwardButtonStyle
        {
            get { return (Style)this.GetValue(ForwardButtonStyleProperty); }
            set { this.SetValue(ForwardButtonStyleProperty, value); }
        }
    }
}