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
    /// Interaction logic for WindowEight.xaml
    /// </summary>
    public partial class WindowEight : Window
    {
        public WindowEight()
        {
            InitializeComponent();
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string a;
            a=e.Text.ToUpper();
            if (a == e.Text)
            {
                textBoxWindow.Text += e.Text.ToLower();
            }
            else
            {
                textBoxWindow.Text += e.Text.ToUpper();
            }
           
        }

        private void TextBoxWindow_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
