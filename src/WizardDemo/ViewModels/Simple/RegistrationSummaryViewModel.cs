namespace WizardDemo.ViewModels.Simple
{
    using System.Threading.Tasks;

    using MvvmWizard.Classes;

    using WizardDemo.Classes;

    /// <summary>
    /// The registration summary view model.
    /// </summary>
    public class RegistrationSummaryViewModel : StepViewModelBase
    {
        /// <summary>
        /// Backing field for the <see cref="UserDetails"/>.
        /// </summary>
        private UserDetails userDetails;

        /// <summary>
        /// Gets or sets the user details.
        /// </summary>
        public UserDetails UserDetails
        {
            get { return this.userDetails; }
            set { this.SetProperty(ref this.userDetails, value); }
        }

        /// <inheritdoc />
        public override Task OnTransitedTo(TransitionContext transitionContext)
        {
            this.UserDetails = transitionContext.SharedContext["UserDetails"] as UserDetails;

            return base.OnTransitedTo(transitionContext);
        }
    }
}