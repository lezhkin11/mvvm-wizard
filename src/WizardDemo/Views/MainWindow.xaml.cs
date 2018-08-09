namespace WizardDemo.Views
{
    using System;
    using System.Windows;
    using System.Windows.Media.Animation;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var customAnimation = new Storyboard();
            AnimationTimeline animationForward =
                new DoubleAnimation()
                    {
                        Duration = new Duration(TimeSpan.FromMilliseconds(2000)),
                        From = 0.2,
                        To = 1.0,
                        DecelerationRatio = 0.9
                    };

            Storyboard.SetTargetProperty(animationForward, new PropertyPath("Opacity"));
            customAnimation.Children.Add(animationForward);

           // this.Wizard1.ForwardTransitionAnimation = customAnimation;
        }
    }
}
