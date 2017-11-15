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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
namespace FotoElektriskEffekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { }
           /* InitializeComponent();
      
            StackPanel myPanel = new StackPanel();
            myPanel.Margin = new Thickness(10);

            Rectangle myRectangle = new Rectangle();
            myRectangle.Name = "myRectangle";
            this.RegisterName(myRectangle.Name, myRectangle);
            myRectangle.Width = 100;
            myRectangle.Height = 100;
            myRectangle.Fill = Brushes.Blue;
            myPanel.Children.Add(myRectangle);
           

            Button toggleLampBtn = new Button();
            toggleLampBtn.Name = "ToggleLamp";
            this.RegisterName(toggleLampBtn.Name, toggleLampBtn);
            toggleLampBtn.Width = 100;
            toggleLampBtn.Height = 25;
            myPanel.Children.Add(toggleLampBtn);
            
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 1.0;
            myDoubleAnimation.To = 0.0;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            myDoubleAnimation.AutoReverse = true;
            myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            Storyboard myStoryboard;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, myRectangle.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Rectangle.OpacityProperty));
            myRectangle.Loaded += new RoutedEventHandler(myRectangleLoaded);
            myStoryboard.Begin(this);

            //this.Content = myPanel;
        }
        private void myRectangleLoaded(object sender, RoutedEventArgs e)
        {
           
        }*/
    }
}
