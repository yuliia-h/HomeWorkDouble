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
using System.Windows.Shapes;

namespace _11122019ClassWork
{
    /// <summary>
    /// Interaction logic for WindowFour.xaml
    /// </summary>
    public partial class WindowFour : Window
    {
        public WindowFour()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBoxA.Text);
            int b = Int32.Parse(textBoxB.Text);
            int c = Int32.Parse(textBoxC.Text);
            if (a > 0 && b > 0 && c > 0)
            {
                if (c < a && c < b)
                {
                    int temp = (a / c) * (b / c);
                    int area = (a * b) - (temp * (c * c));
                    labelInfoCount.Content="In rectangle count " + temp + " and unoccupied area " + area ;

                }
                else MessageBox.Show("Not square in ...!!!");
            }
            else
            {
                MessageBox.Show("Enter please positive number!!!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowFive windowFive = new WindowFive();
            windowFive.Show();
            this.Close();
        }
    }
}
