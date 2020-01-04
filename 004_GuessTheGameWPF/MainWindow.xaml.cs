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
using System.Windows.Threading;

namespace _004_GuessTheGameWPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timerTick;
            timer.Start();
        }
        private int second = 0;
        private int minutes = 0;
        private int milisec = 0;
        private void timerTick(object sender, EventArgs e)
        {
            labelPoint.Visibility = Visibility.Visible;
            if (second < 59) 
            {
                second++;
                if (second < 10)
                    labelTimerSec.Content = "0" + second.ToString();
                else
                    labelTimerSec.Content = second.ToString();
            }
            else
            {
                if (minutes < 59)
                {
                    minutes++;
                    if (minutes < 10)
                        labelTimerMinut.Content = "0" + minutes.ToString();
                    else
                        labelTimerMinut.Content = minutes.ToString();
                    second = 0;
                    labelTimerSec.Content = "00";
                    
                }
                else
                {
                    minutes = 0;
                    labelTimerSec.Content = "00";
                    
                }
            }
            labelPoint.Visibility = Visibility.Hidden;
        }

        public int rightAnswer { get; set; }
        public int count { get; set; }
        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            count++;
            switch (count)
            {
                case 1:
                    QuestionOne.Visibility = Visibility.Hidden;
                    QuestionTwo.Visibility = Visibility.Visible;
                    progressBar.Value = 60;
                    labelNumber.Content = 2;
                    break;
                case 2:                   
                    QuestionTwo.Visibility = Visibility.Hidden;
                    QuestionThree.Visibility = Visibility.Visible;
                    buttonNext.Visibility = Visibility.Hidden;
                    progressBar.Value = 100;
                    labelNumber.Content = 3;
                    break;
            } 
        }
        
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Visibility = Visibility.Hidden;
            Game.Visibility = Visibility.Hidden;
            GameTheEnd.Visibility = Visibility.Visible;
            if (rightAnswer == 3) labelFinish.Content += 
                    rightAnswer + " questions, you very good know games!!!";            
            else if (rightAnswer == 2) labelFinish.Content +=
                    rightAnswer + " questions, you not goof know games:)";
            else if (rightAnswer <= 1) labelFinish.Content += rightAnswer+
                    " questions, you know bad games (:";
        }        
        void answerTrue(object sender, RoutedEventArgs e)
        {
            rightAnswer++;
        }
    }
    
}
