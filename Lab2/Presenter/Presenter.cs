using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Lab1_Sec.Presenter
{
    class Presenter
    {
        private readonly MainWindow window;
        Model.Model model;
        DispatcherTimer timer = new DispatcherTimer();
        public Presenter(MainWindow window1)
        {
            model = new Model.Model();
            window = window1;
            window.Action += DoThings;
        }
        public void DoThings(object s, EventArgs e)
        {
            var symbol = (s as Button).Content.ToString();
            window.AnswerLabel.Content = model.Eval($"{window.A.Text}{symbol}{window.B.Text}");
        }
        
    }
}
