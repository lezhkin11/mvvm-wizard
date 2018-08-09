namespace WizardDemo.Views.Simple
{
    using System.Windows.Controls;

    using WizardDemo.ViewModels;
    using WizardDemo.ViewModels.Simple;

    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        public RegistrationView(RegistrationViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
