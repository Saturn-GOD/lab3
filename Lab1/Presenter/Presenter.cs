using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;
using Lab1_Sec.Model;

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
            window.Start += Window_Start;
            window.Stop += Window_Stop;
            window.Reset += Window_Reset;

            timer.Tick += TimerTick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            timer.IsEnabled = false;

        }
        private void TimerTick(object s, EventArgs e)
        {
            window.TimerText.Text = model.Time();
        }
        private void Window_Start(object s, EventArgs e)
        {
            timer.Start();
            timer.IsEnabled = true;
        }
        private void Window_Stop(object s, EventArgs e)
        {
            timer.Stop();
            timer.IsEnabled = false;
        }
        private void Window_Reset(object s, EventArgs e)
        {
            model.Clear();
            timer.Stop();
            window.TimerText.Text = "0";
        }
    }
}
