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

namespace HY_HomeWork01_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow();

            if (Cube.IsChecked == true && SquareCube.IsChecked == true && CubeEdge.IsChecked == true)
            {               
                taskWindow.Show();
            }
            
        }

        private void bottonRandom_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBoxCount.Text);
            double min=double.Parse(textBoxMin.Text);
            double max= double.Parse(textBoxMax.Text);
            int countComma=Int32.Parse(textBoxNumberComma.Text);

            Random rand = new Random();

            switch (countComma)
            {
                case 1:
                    for (int w = 1; w <= a; w++)
                    {
                        double temp3;
                        temp3 = rand.NextDouble() * (max - min) + min;
                        textBoxRandom.Text += Math.Round(temp3,1)+" ";
                    }
                    break;
                case 2:
                    for (int w = 1; w <= a; w++)
                    {
                        double temp3;
                        temp3 = rand.NextDouble() * (max - min) + min;
                        textBoxRandom.Text += Math.Round(temp3, 2) + " ";
                    }
                    break;
                case 3:
                    for (int w = 1; w <= a; w++)
                    {
                        double temp3;
                        temp3 = rand.NextDouble() * (max - min) + min;
                        textBoxRandom.Text += Math.Round(temp3, 3) + " ";
                    }
                    break;
                default:
                    for (int w = 1; w <= a; w++)
                    {
                        double temp3;
                        temp3 = rand.NextDouble() * (max - min) + min;
                        textBoxRandom.Text += Math.Round(temp3, 0) + " ";
                    }
                    break;
            }            
        }
    }
}
