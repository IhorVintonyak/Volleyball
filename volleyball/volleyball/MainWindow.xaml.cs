using System;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace volleyball
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn1Serve_Click(object sender, RoutedEventArgs e)
        {
            
            Grid.SetRow(ball, 0);
            Grid.SetColumn(ball, 0);
 
        }

        private void btn2Serve_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(ball, 0);
            Grid.SetColumn(ball, 2);
        }



        void response()
        {
            
            Random random = new Random();
            int RandomNumber = random.Next(0, 2);
            Grid.SetRow(ball, 5);
            if (RandomNumber == 0)
            {
                Grid.SetColumn(ball, RandomNumber);
            }
            else
            {
                Grid.SetColumn(ball, 2);
            }
            
        }

        void attackConfiguration()
        {
            txtblNameAction.Text = "Attack";
            btn1Set.Visibility = Visibility.Visible;
            btn2Set.Visibility = Visibility.Visible;

            btn1Spike.Visibility = Visibility.Visible;
            btn2Spike.Visibility = Visibility.Visible;

            btn1Serve.Visibility = Visibility.Hidden;
            btn2Serve.Visibility = Visibility.Hidden;

            imgConfiguration.Source = new BitmapImage(new Uri("D:\\zz\\GITHUB\\Volleyball\\volleyball\\volleyball\\img\\redAttack.png"));
            /*
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            this.RegisterName(Player2Blue.Name, Player2Blue);
            myDoubleAnimation.From =100;
            myDoubleAnimation.To = 300;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(300));



            // Configure the animation to target the button's Width property.
            Storyboard.SetTargetName(myDoubleAnimation, Player2Blue.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Image.));

            // Create a storyboard to contain the animation.
            Storyboard myWidthAnimatedButtonStoryboard = new Storyboard();
            myWidthAnimatedButtonStoryboard.Children.Add(myDoubleAnimation);


            myWidthAnimatedButtonStoryboard.Begin(Player2Blue);
            */

            

        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            response();
            attackConfiguration();

        }
    }
}
