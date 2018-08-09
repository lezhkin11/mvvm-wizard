namespace MvvmWizard.Classes
{
    using System.Threading.Tasks;

    using MvvmWizard.Interfaces;

    /// <summary>
    /// The step view model base.
    /// </summary>
    public abstract class StepViewModelBase : BindableBase, ITransitionAware
    {
        /// <inheritdoc />
        public TransitionController TransitionController { get; set; }

        /// <inheritdoc />
        public virtual Task OnTransitedTo(TransitionContext transitionContext)
        {
            return Task.FromResult<object>(null);
        }

        /// <inheritdoc />
        public virtual Task OnTransitedFrom(TransitionContext transitionContext)
        {
            return Task.FromResult<object>(null);
        }
    }
}