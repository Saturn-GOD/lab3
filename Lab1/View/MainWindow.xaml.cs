using System;
using System.Windows;
using System.Windows.Input;

namespace Lab1_Sec
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter.Presenter(this);
        }
        public event EventHandler Start, Stop, Reset;

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            Reset(sender, e);
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            Stop(sender, e);
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Start(sender, e);
        }
    }
}
