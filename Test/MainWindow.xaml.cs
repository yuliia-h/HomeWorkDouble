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

namespace Test
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
            
            
            //Uri uri = new Uri(@"E:\C# usb\MyProject USB\HomeWorkDouble\Test\1.png");
            //BitmapImage bitmap = new BitmapImage(uri);
            //Image img = new Image();
            //image.Source = bitmap;

            // Добавить изображение в окно  

            
            image.Source = new BitmapImage(new Uri(@"E:\C# usb\MyProject USB\HomeWorkDouble\Test\1.png"));

            image.Source = new BitmapImage(new Uri(@"E:\C# usb\MyProject USB\HomeWorkDouble\Test\2.png"));


        }
    }
}
