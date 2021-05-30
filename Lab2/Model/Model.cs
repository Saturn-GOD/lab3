using System;
using System.Data;

namespace Lab1_Sec.Model
{

    class Model
    {
        public Double Eval(String expression)
        {
            Double val;
            DataTable table = new DataTable();
            try
            {
                val = Convert.ToDouble(table.Compute(expression, String.Empty));
            }
            catch (Exception)
            {
                val = 32202;
            }
            return val;
        }
    }
}
