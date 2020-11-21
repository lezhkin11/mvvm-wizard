namespace MvvmWizard.Classes
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// The simple command.
    /// </summary>
    public class SimpleCommand : ICommand
    {
        /// <summary>
        /// The execute delegate.
        /// </summary>
        private readonly Action executeMethod;

        /// <summary>
        /// The can execute delegate.
        /// </summary>
        private readonly Func<bool> canExecuteMethod;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommand"/> class.
        /// </summary>
        /// <param name="executeMethod">
        /// The <see cref="Action" /> to invoke when <see cref="ICommand.Execute" /> is called.
        /// </param>
        public SimpleCommand(Action executeMethod)
            : this(executeMethod, () => true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommand"/> class.
        /// </summary>  
        /// <param name="executeMethod">
        /// The <see cref="Action" /> to invoke when <see cref="ICommand.Execute" /> is called.
        /// </param>
        /// <param name="canExecuteMethod">
        /// The <see cref="Func{TResult}" /> to invoke when <see cref="ICommand.CanExecute" /> is called
        /// </param>
        public SimpleCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            this.executeMethod = executeMethod ?? throw new ArgumentNullException(nameof(executeMethod), "Execute method cannot be null");
            this.canExecuteMethod = canExecuteMethod ?? throw new ArgumentNullException(nameof(canExecuteMethod), "CanExecute method cannot be null");
        }

        /// <inheritdoc />
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Gets a value indicating whether current command can be executed.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if command can be executed, otherwise <see langword="false" />.
        /// </returns>
        public bool CanExecute()
        {
            return this.canExecuteMethod();
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        public void Execute()
        {
            if (this.CanExecute())
            {
                this.executeMethod();
            }
        }

        /// <inheritdoc />
        public bool CanExecute(object parameter)
        {
            return this.CanExecute();
        }

        /// <inheritdoc />
        public void Execute(object parameter)
        {
            this.Execute();
        }
    }
}