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
    /// Interaction logic for WindowTwo.xaml
    /// </summary>
    public partial class WindowTwo : Window
    {
        public WindowTwo()
        {
            InitializeComponent();

            //Button buttonTwo = new Button();
            //buttonTwo.Width = 200;
            //buttonTwo.Height = 30;
            //buttonTwo.Content = "Find perimeter anf area";            
            //layoutGrid.Children.Add(buttonTwo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxx1.Text == "" || textBoxx2.Text == "" || textBoxx3.Text == "" || textBoxy1.Text == "" || textBoxy2.Text == "" || textBoxy3.Text == "") 
            {
                MessageBox.Show("Not all data entered!!!");
            } 
            else
            { 
            int x1 = Int32.Parse(textBoxx1.Text);
            int x2 = Int32.Parse(textBoxx2.Text);
            int x3 = Int32.Parse(textBoxx3.Text);
            int y1 = Int32.Parse(textBoxy1.Text);
            int y2 = Int32.Parse(textBoxy2.Text);
            int y3 = Int32.Parse(textBoxy3.Text);

            double perimeter, square;
            
            perimeter = Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) +
                Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) +
                Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5);

            double p8 = perimeter / 2;

            square = Math.Sqrt((p8 * (p8 - Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) *
                (p8 - Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) *
                (p8 - Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5))))));

            labelPerimeter.Content = "Периметр треугольника по заданным координатам:"+ Environment.NewLine + Math.Round(perimeter,2);

            labelArea.Content = "Площадь треугольна равна"+ Environment.NewLine + Math.Round(square,2);
        }
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowThree windowThree = new WindowThree();
            windowThree.Show();
            this.Close();
        }
    }
}
