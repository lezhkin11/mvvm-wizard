namespace MvvmWizard.Classes
{
    using System;
    using System.Windows.Input;

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
            Action finishMethod)
        {
            this.PreviousStepCommand = new SimpleCommand(previousStepMethod);
            this.NextStepCommand = new SimpleCommand(nextStepMethod);
            this.SkipStepCommand = new SimpleCommand(skipStepMethod);

            this.FinishCommand = new SimpleCommand(finishMethod);
        }

        /// <summary>
        /// Gets the command, which performs transition to the previous step.
        /// </summary>
        public ICommand PreviousStepCommand { get; }

        /// <summary>
        /// Gets the command, which performs transition to the next step.
        /// </summary>
        public ICommand NextStepCommand { get; }

        /// <summary>
        /// Gets the command, which skips the step.
        /// </summary>
        public ICommand SkipStepCommand { get; }

        /// <summary>
        /// Gets the command, which closes wizard.
        /// </summary>
        public ICommand FinishCommand { get; }
    }
}