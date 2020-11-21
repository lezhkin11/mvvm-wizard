namespace MvvmWizard.Classes
{
    using System;
    using System.Windows.Input;

    public class SimpleGenericCommand<TParameter> : ICommand
    {
        private readonly Action<TParameter> executeMethod;
        private readonly Func<bool> canExecuteMethod;
        private readonly Func<TParameter> defaultParameterFunc;

        public SimpleGenericCommand(Action<TParameter> executeMethod, Func<TParameter> defaultParameterFunc = null)
            : this(executeMethod, () => true, defaultParameterFunc)
        {
        }

        public SimpleGenericCommand(
            Action<TParameter> executeMethod,
            Func<bool> canExecuteMethod,
            Func<TParameter> defaultParameterFunc = null)
        {
            this.executeMethod = executeMethod ?? throw new ArgumentNullException(nameof(executeMethod), "Execute method cannot be null");
            this.canExecuteMethod = canExecuteMethod ?? throw new ArgumentNullException(nameof(canExecuteMethod), "CanExecute method cannot be null");
            this.defaultParameterFunc = defaultParameterFunc;
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

        public void Execute()
        {
            if (defaultParameterFunc is null)
            {
                this.Execute(null);
                return;
            }

            this.Execute(defaultParameterFunc());
        }

        public void Execute(TParameter parameter)
        {
            if (this.CanExecute())
            {
                this.executeMethod(parameter);
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
            this.Execute((TParameter)parameter);
        }
    }
}