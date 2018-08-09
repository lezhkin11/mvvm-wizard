// ReSharper disable StyleCop.SA1600
namespace WizardDemo.Behaviors
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Interactivity;

    using MahApps.Metro.Controls;

    using MvvmWizard.Controls;

    /// <summary>
    /// The apply value to all summary items behavior.
    /// </summary>
    public class ApplyValueToAllSummaryItemsBehavior : Behavior<FrameworkElement>
    {
        /// <summary>
        /// The dependency property that represents <see cref="PropertyName"/>.
        /// </summary>
        public static readonly DependencyProperty PropertyNameProperty = DependencyProperty.Register(
            nameof(PropertyName),
            typeof(string),
            typeof(ApplyValueToAllSummaryItemsBehavior));

        /// <summary>
        /// The dependency property that represents <see cref="Value"/>.
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value),
            typeof(object),
            typeof(ApplyValueToAllSummaryItemsBehavior),
            new PropertyMetadata(ValuePropertyChangedCallback));

        /// <summary>
        /// The wizard.
        /// </summary>
        private Wizard wizard;

        /// <summary>
        /// Property to be set.
        /// </summary>
        private PropertyDescriptor propertyToSet;

        /// <summary>
        /// Gets or sets the name of the property that will be changed.
        /// </summary>
        public string PropertyName
        {
            get { return (string)this.GetValue(PropertyNameProperty); }
            set { this.SetValue(PropertyNameProperty, value); }
        }

        public object Value
        {
            get { return this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <inheritdoc />
        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += this.TryFindWizard;
        }

        /// <inheritdoc />
        protected override void OnDetaching()
        {
        }

        /// <summary>
        /// Occurs when <see cref="Value"/> changes.
        /// </summary>
        /// <param name="newValue">
        /// The new value.
        /// </param>
        protected virtual void OnValueChanged(object newValue)
        {
            foreach (WizardStep step in this.wizard.Items.OfType<WizardStep>())
            {
                Type valueType = newValue.GetType();

                if (this.propertyToSet.PropertyType != valueType)
                {
                    if (this.propertyToSet.Converter.CanConvertFrom(valueType))
                    {
                        newValue = this.propertyToSet.Converter.ConvertFrom(newValue);
                    }
                }
                
                this.propertyToSet.SetValue(step, newValue);
            }
        }

        /// <summary>
        /// The callback for the <see cref="ValueProperty"/>
        /// </summary>
        /// <param name="d">
        /// The dependency object.
        /// </param>
        /// <param name="e">
        /// The event args.
        /// </param>
        private static void ValuePropertyChangedCallback(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var control = (ApplyValueToAllSummaryItemsBehavior)d;

            if (control.AssociatedObject == null)
            {
                return;
            }

            control.OnValueChanged(e.NewValue);
        }

        private void TryFindWizard(object sender, RoutedEventArgs routedEventArgs)
        {
            this.AssociatedObject.Loaded -= this.TryFindWizard;

            this.wizard = this.AssociatedObject.TryFindParent<Wizard>();
            this.propertyToSet = TypeDescriptor.GetProperties(typeof(WizardStep)).Find(this.PropertyName, false);
        }
    }
}