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
    /// Interaction logic for WindowSix.xaml
    /// </summary>
    public partial class WindowSix : Window
    {
        public WindowSix()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtContent.Text="";
            txtContent.Clear();
            labelInfoSpace.Content = "";
        }

        int countSpace = 0;
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != ".")
            {
                                
            }
            else if(e.Text == ".")
            {
                MessageBox.Show("Stop input!!!");
                labelInfoSpace.Content = " CountSpace = " + countSpace;
                e.Handled = true;
                txtContent.IsReadOnly = true;
            }

        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                countSpace++;
                //e.Handled = true; // если пробел, отклоняем ввод
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowSeven windowSeven = new WindowSeven();
            windowSeven.Show();
            this.Close();
        }
    }
}
