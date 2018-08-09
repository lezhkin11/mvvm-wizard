namespace MvvmWizard.Classes
{
    using System;

    /// <summary>
    /// The wizard settings.
    /// </summary>
    public class WizardSettings
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly WizardSettings Instance = new WizardSettings();

        /// <summary>
        /// Prevents a default instance of the <see cref="WizardSettings"/> class from being created.
        /// </summary>
        private WizardSettings()
        {
        }

        /// <summary>
        /// Gets or sets the view resolver (DI container).
        /// </summary>
        /// <example>
        /// WizardSettings.Instance.ViewResolver = type => unityContainer.Resolve(type);
        /// </example>
        public Func<Type, object> ViewResolver { get; set; }
    }
}