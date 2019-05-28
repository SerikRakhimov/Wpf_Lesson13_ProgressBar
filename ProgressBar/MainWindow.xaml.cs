using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressBar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            textBlock.Visibility = Visibility.Hidden;
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = rectangle.Width;
            animation.Completed += AnimationCompleted;
            animation.To = rectangle.Width + 600;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            //animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.AutoReverse = false;
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, rectangle.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));
            storyboard.Begin(this);

        }

        private void AnimationCompleted(object sender, EventArgs e)
        {
            textBlock.Visibility = Visibility.Visible;
        }

    }
}
