namespace MvvmWizard.Classes
{
    using System;

    /// <summary>
    /// The transition controller.
    /// </summary>
    public class TransitionController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionController"/> class.
        /// </summary>
        /// <param name="previousStepMethod">
        /// The show previous step method.
        /// </param>
        /// <param name="nextStepMethod">
        /// The show next step method.
        /// </param>
        /// <param name="skipStepMethod">
        /// The skip step method.
        /// </param>
        /// <param name="finishMethod">
        /// The close/finish wizard method.
        /// </param>
        public TransitionController(
            Action previousStepMethod,
            Action nextStepMethod,
            Action skipStepMethod,
            Action<object> finishMethod,
            Func<object> sharedContextFunc)
        {
            this.PreviousStepCommand = new SimpleCommand(previousStepMethod);
            this.NextStepCommand = new SimpleCommand(nextStepMethod);
            this.SkipStepCommand = new SimpleCommand(skipStepMethod);

            this.FinishCommand = new SimpleGenericCommand<object>(finishMethod, sharedContextFunc);
        }

        /// <summary>
        /// Gets the command, which performs transition to the previous step.
        /// </summary>
        public SimpleCommand PreviousStepCommand { get; }

        /// <summary>
        /// Gets the command, which performs transition to the next step.
        /// </summary>
        public SimpleCommand NextStepCommand { get; }

        /// <summary>
        /// Gets the command, which skips the step.
        /// </summary>
        public SimpleCommand SkipStepCommand { get; }

        /// <summary>
        /// Gets the command, which closes wizard.
        /// </summary>
        public SimpleGenericCommand<object> FinishCommand { get; }
    }
}