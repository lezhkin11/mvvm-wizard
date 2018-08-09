namespace MvvmWizard.Classes
{
    using System.Collections.Generic;

    using MvvmWizard.Controls;

    /// <summary>
    /// The transition context.
    /// </summary>
    public class TransitionContext
    {
        /// <summary>
        /// Gets the shared context.
        /// </summary>
        public Dictionary<string, object> SharedContext { get; internal set; }

        /// <summary>
        /// Gets all the step indices.
        /// uses "x:Name" of the <see cref="Wizard"/> element to associate index with the constant.
        /// </summary>
        public Dictionary<int, string> StepIndices { get; internal set; }

        /// <summary>
        /// Gets the index of the step is being navigated away from.
        /// </summary>
        public int TransitedFromStep { get; internal set; }

        /// <summary>
        /// Gets or sets index of the step has been navigated to.
        /// </summary>
        public int TransitToStep { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether transition should be aborted.
        /// </summary>
        public bool AbortTransition { get; set; }

        /// <summary>
        /// Gets a value indicating whether current transition was invoked by <see cref="TransitionController.SkipStepCommand"/>.
        /// </summary>
        public bool IsSkipAction { get; internal set; }
    }
}