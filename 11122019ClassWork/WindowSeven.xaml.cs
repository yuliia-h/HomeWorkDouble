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
    /// Interaction logic for WindowSeven.xaml
    /// </summary>
    public partial class WindowSeven : Window
    {
        public WindowSeven()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBoxTicket.Text);
            int sumleft=0, sumright=0, temp2=a;
            for(int i = 1; i <= 3; i++)
            {
                
                sumright += (temp2 % 10);
                temp2 /= 10;

            }
            int temp = a / 1000;
            for (int i = 1; i <= 3; i++)
            {
                sumleft += (temp % 10);
                temp /= 10;
            }
            if (sumright == sumleft)
            {
                labelHappyTicket.Content = /*"sumright = " + sumright +
                    Environment.NewLine+ "sumleft = "+sumleft+*/
                    Environment.NewLine+ "ticket happy";
            }
            else labelHappyTicket.Content = /*"sumright = " + sumright +
                    Environment.NewLine + "sumleft = " + sumleft +*/
                    Environment.NewLine + "ticket not happy";

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowEight windowEight = new WindowEight();
            windowEight.Show();
            this.Close();
        }
    }
}
