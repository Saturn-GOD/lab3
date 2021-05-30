using System;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace Lab1_Sec
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter.Presenter(this);
        }
        public event EventHandler Action;

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Action(sender, e);
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
