namespace WizardDemo.ViewModels
{
    using System.Windows;
    using System.Windows.Input;

    using MvvmWizard.Classes;

    using Unity;

    using WizardDemo.Views.Advanced;

    using SimpleDemoDialog = WizardDemo.Views.Simple.SimpleDemoDialog;

    /// <summary>
    /// The main window view model.
    /// </summary>
    public class MainWindowViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            var unityContainer = new UnityContainer();
            WizardSettings.Instance.ViewResolver = type => unityContainer.Resolve(type);

            this.StartSimpleDemoCommand = new SimpleCommand(() => this.StartDemo(new SimpleDemoDialog()));
            this.StartAdvancedDemoCommand = new SimpleCommand(() => this.StartDemo(new AdvancedDemoDialog()));
        }

        /// <summary>
        /// Gets the start simple demo command.
        /// </summary>
        public ICommand StartSimpleDemoCommand { get; }

        /// <summary>
        /// Gets the start settings demo command.
        /// </summary>
        public ICommand StartAdvancedDemoCommand { get; }

        /// <summary>
        /// Starts given demo/dialog.
        /// </summary>
        /// <param name="dialog">
        /// The dialog to be shown.
        /// </param>
        private void StartDemo(Window dialog)
        {
            dialog.Owner = Application.Current.MainWindow;
            dialog.WindowState = WindowState.Normal;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dialog.Show();
            dialog.Activate();
        }
    }
}