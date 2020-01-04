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
    /// Interaction logic for WindowFive.xaml
    /// </summary>
    public partial class WindowFive : Window
    {
        public WindowFive()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowSix windowSix = new WindowSix();
            windowSix.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double deposit=1000.0, rate;
            rate = double.Parse(textBoxRate.Text);
            double newDeposit = deposit;
            int month = 0;
            do
            {
                newDeposit += (newDeposit * rate)/100;
                month++;
            }
            while (newDeposit < 1100);
            labelInfoDepozit.Content = "Deposit more 1100 $ " +
                Environment.NewLine + " for month " + month +
                Environment.NewLine + " Deposit amount is " + Math.Round(newDeposit,2) + "$";
           
        }
    }
}
