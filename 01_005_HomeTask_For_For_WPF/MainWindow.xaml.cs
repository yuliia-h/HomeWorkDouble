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

namespace _01_005_HomeTask_For_For_WPF
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
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1; i <= 4; i++, Console.WriteLine()"+Environment.NewLine+
               "{ for (int j = 1; j <= 6; j++)"+Environment.NewLine+
               "Console.Write(\u0022 \u0022 + i);}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1; i <= 4; i++, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= 10; ++j)" + Environment.NewLine +
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1; i <= 5; i++, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= 12; ++j)" + Environment.NewLine +
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
                "int j = 41;"+Environment.NewLine+
               "for (; i <= 10; i++, j++ " + Environment.NewLine +               
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1; i <= 5; i++, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= i; j++)" + Environment.NewLine +
               "Console.Write(5 + \u0022 \u0022);}";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 5; i >= 1; --i, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = i; j >= 1; --j)" + Environment.NewLine +
               "Console.Write(1 + \u0022 \u0022);}";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1; i <= 5; ++i, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= i; ++j)" + Environment.NewLine +
               "Console.Write(i + \u0022 \u0022);}";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 5; k = 6; i >= 1; --i, ++k, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = i; j >= 1; --j)" + Environment.NewLine +
               "Console.Write(k + \u0022 \u0022);}";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1, k = 7; i <= 5; ++i, --k, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= i; ++j)" + Environment.NewLine +
               "Console.Write(k + \u0022 \u0022);}";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 5, k = 8; i >= 1; --i, --k, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= i; ++j)" + Environment.NewLine +
               "Console.Write(k + \u0022 \u0022);}";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i=1;i<=5;++i, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = 1; j <= i; ++j)" + Environment.NewLine +
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i=1;i<=5;++i, Console.WriteLine()" + Environment.NewLine +
               "{ for (int j = i; j >= 1; j--)" + Environment.NewLine +
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 5; i > 0; --i,Console.WriteLine())" + Environment.NewLine +
               "{ for (int j = 0; j < i; ++j)" + Environment.NewLine +
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i=4;i>=0;--i,Console.WriteLine())" + Environment.NewLine +
               "{ for (int j = i; j >= 0; --j)" + Environment.NewLine +
               "Console.Write(j + \u0022 \u0022);}";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1; i <= 5; ++i)" + Environment.NewLine +
            "{" + Environment.NewLine +
             "   for (int j = 1; j <= i; ++j)" + Environment.NewLine +
             "   {" + Environment.NewLine +
             "       Console.Write(i +  \u0022 \u0022);" + Environment.NewLine +
             "   }" + Environment.NewLine +
             "   Console.WriteLine();" + Environment.NewLine +
             "   for (int j = 1; j <= i; ++j)" + Environment.NewLine +
             "   {" + Environment.NewLine +
             "       Console.Write(0 +  \u0022 \u0022);" + Environment.NewLine +
             "   }" + Environment.NewLine +
             "   Console.WriteLine();" + Environment.NewLine +
            "}";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for(int i=1,k=8;i<=4;++i,Console.WriteLine())" + Environment.NewLine +
            "{" + Environment.NewLine +
             "   for (int j = 1; j <= i; j++, Console.Write(k + \u0022 \u0022)) ;" + Environment.NewLine +
             " k--;" + Environment.NewLine +
             "       Console.WriteLine();" + Environment.NewLine +
             " for (int j = 1; j <= i; j++, Console.Write(k + \u0022 \u0022)) ;" + Environment.NewLine +             
            "}";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1;  i <= 4; ++i, Console.WriteLine())" + Environment.NewLine +
            "{" + Environment.NewLine +
             "   for (int j = 1; j <= i; j++, Console.Write(i + \u0022 \u0022)) ;" + Environment.NewLine +             
             "       Console.WriteLine();" + Environment.NewLine +
             "for (int j = 1; j <= i; j++, Console.Write(i+5 + \u0022 \u0022)) ;" + Environment.NewLine +
            "}";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
               "for (int i = 1,c=9,d=4; i <= 4; ++i, Console.WriteLine())" + Environment.NewLine +
            "{" + Environment.NewLine +
             "   for (int j = 1; j <= i; j++, Console.Write(c + \u0022 \u0022)) ; c--;" + Environment.NewLine +
             "       Console.WriteLine();" + Environment.NewLine +
             "for (int j = 1; j <= i; j++, Console.Write(d + \u0022 \u0022)) ; d--;" + Environment.NewLine +
            "}";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
            "for (int i = 1, y = 10; i < 6; ++i, Console.WriteLine()) " + Environment.NewLine +
            "{" + Environment.NewLine +
             "   for (int j = i, z = 3; j > 0; --j) " + Environment.NewLine +
             "   {" + Environment.NewLine +
             "       if (i >= 2 && j >= 2) Console.Write(\u0022 \u0022 + 2); " + Environment.NewLine +
             "      else Console.Write(\u0022 \u0022 + z); " + Environment.NewLine +
             "  }" + Environment.NewLine +
             "   Console.WriteLine(); " + Environment.NewLine +
             "   for (int q = i, h = 0; q > 0; --q, ++h) " + Environment.NewLine +
             "   {" + Environment.NewLine +
             "       if (q == 1) Console.Write(\u0022 \u0022 + 0); " + Environment.NewLine +
             "      else Console.Write(\u0022 \u0022 + (y + h)); " + Environment.NewLine +
             "   }" + Environment.NewLine +
             "   --y; " + Environment.NewLine +
            "}";
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Text +=
                "int x = 3; " + Environment.NewLine +
            "for (int i = 1, y = 6; i <= 5; ++i, --y, Console.WriteLine()) " + Environment.NewLine +
            "{" + Environment.NewLine +
             "   for (int j = i; j <= 5; ++j) " + Environment.NewLine +
             "   {" + Environment.NewLine +
             "      Console.Write(\u0022 \u0022 + \u00222\u0022); " + Environment.NewLine +
             "  }" + Environment.NewLine +
             "   Console.WriteLine(); " + Environment.NewLine +
             "   for (int z = i; z <= 5; ++z, ++x) " + Environment.NewLine +
             "   {" + Environment.NewLine +
             "       Console.Write(\u0022 \u0022 + x); " + Environment.NewLine +             
             "   }" + Environment.NewLine +
             "  x -= y; " + Environment.NewLine +
            "}";           
        }
    }
}
