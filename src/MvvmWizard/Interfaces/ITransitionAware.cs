namespace MvvmWizard.Interfaces
{
    using System.Threading.Tasks;

    using MvvmWizard.Classes;

    /// <summary>
    /// The TransitionAware interface.
    /// </summary>
    public interface ITransitionAware
    {
        /// <summary>
        /// Gets or sets the transition controller.
        /// </summary>
        TransitionController TransitionController { get; set; }

        /// <summary>
        /// Called when the implementer has been navigated to.
        /// </summary>
        /// <param name="transitionContext">
        /// The transition context.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task OnTransitedTo(TransitionContext transitionContext);

        /// <summary>
        /// Called when the implementer is being navigated away from.
        /// </summary>
        /// <param name="transitionContext">
        /// The transition context.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task OnTransitedFrom(TransitionContext transitionContext);
    }
}