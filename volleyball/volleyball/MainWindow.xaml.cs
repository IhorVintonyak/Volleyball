using System;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace volleyball
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            
            Grid.SetRow(ball, 0);
            Grid.SetColumn(ball, 0);
 
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
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

        void changeActionToAttack()
        {
            txtblNameAction.Text = "Attack";
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            response();


        }
    }
}
