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
    /// Interaction logic for WindowThree.xaml
    /// </summary>
    public partial class WindowThree : Window
    {
        public WindowThree()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBoxNumber.Text);
            
            string numberWords="";

            int humdreds, tens, units;
            if (a >= 100 && a <= 999)
            {
                humdreds = a / 100;
                tens = a % 100;
                if (tens > 19)
                {
                    units = tens % 10;
                    tens = tens / 10;                   
                }

                switch (humdreds)
                {
                    case 1:
                        numberWords += "Сто ";
                        break;
                    case 2:
                        numberWords += "Двести ";
                        break;
                    case 3:
                        numberWords += "Триста ";
                        break;
                    case 4:
                        numberWords += "Четыреста ";
                        break;
                    case 5:
                        numberWords += "Пятьсот ";
                        break;
                    case 6:
                        numberWords += "Шестьсот ";
                        break;
                    case 7:
                        numberWords += "Семьсот ";
                        break;
                    case 8:
                        numberWords += "Восемьсот ";
                        break;
                    case 9:
                        numberWords += "Девятьсот ";
                        break;
                }
                if (tens > 1 && tens <= 9)
                {
                    switch (tens)
                    {
                        case 2:
                            numberWords += "двадцать ";
                            break;
                        case 3:
                            numberWords += "тридцать ";
                            break;
                        case 4:
                            numberWords += "сорок ";
                            break;
                        case 5:
                            numberWords += "пятьдесят ";
                            break;
                        case 6:
                            numberWords += "шестьдесят ";
                            break;
                        case 7:
                            numberWords += "семьдесят ";
                            break;
                        case 8:
                            numberWords += "восемьдесят ";
                            break;
                        case 9:
                            numberWords += "девяносто ";
                            break;
                    }
                }
                else if (tens > 9 && tens <= 19) 
                {
                    switch (tens)
                    {
                        case 10:
                            numberWords += "десять ";
                            break;
                        case 11:
                            numberWords += "одиннадцать ";
                            break;
                        case 12:
                            numberWords += "двенадцать ";
                            break;
                        case 13:
                            numberWords += "тринадцать ";
                            break;
                        case 14:
                            numberWords += "четырнадцать ";
                            break;
                        case 15:
                            numberWords += "пятнадцать ";
                            break;
                        case 16:
                            numberWords += "шестнадцать ";
                            break;
                        case 17:
                            numberWords += "семнадцать ";
                            break;
                        case 18:
                            numberWords += "восемнадцать ";
                            break;
                        case 19:
                            numberWords += "девятнадцать ";
                            break;
                    }
                };                

                laberNumberWords.Content = numberWords;
            }
            else
            {
                MessageBox.Show("The number is wrong!!!");
                textBoxNumber.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowFour windowFour = new WindowFour();
            windowFour.Show();
            this.Close();
        }
    }
}
