using System.Collections.Generic;

namespace WizardDemo.Views.Simple
{
    using System.Windows.Input;

    using MvvmWizard.Classes;

    /// <summary>
    /// Interaction logic for SimpleDemoDialog.xaml
    /// </summary>
    public partial class SimpleDemoDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDemoDialog"/> class.
        /// </summary>
        public SimpleDemoDialog()
        {
            this.CloseCommand = new SimpleGenericCommand<Dictionary<string, object>>(ExecuteMethod);

            this.InitializeComponent();
        }

        private void ExecuteMethod(Dictionary<string, object> obj)
        {
            this.Close();
        }

        /// <summary>
        /// Gets the close command.
        /// </summary>
        public ICommand CloseCommand { get; }
    }
}
