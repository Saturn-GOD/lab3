using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Sec.Model
{
    class Model
    {
        
        private int s;
        public string Time()
        {
            s += 1;
            return (s >= 60) ? "min. " + s / 60 + " s. " + s % 60 : s.ToString();
        }
        public void Clear()
        {
            s = 0;
        }
    }
}
