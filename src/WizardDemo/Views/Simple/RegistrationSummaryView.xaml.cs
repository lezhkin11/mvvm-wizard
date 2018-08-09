namespace WizardDemo.Views.Simple
{
    using System.Windows.Controls;

    using WizardDemo.ViewModels;
    using WizardDemo.ViewModels.Simple;

    /// <summary>
    /// Interaction logic for RegistrationSummaryView.xaml
    /// </summary>
    public partial class RegistrationSummaryView : UserControl
    {
        public RegistrationSummaryView(RegistrationSummaryViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
