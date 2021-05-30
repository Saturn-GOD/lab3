using System;
using System.Threading;

namespace Lab3_4Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 42);

            Matrix instance;

            for (int i = 0; i < 26; i++)
            {
                instance = new Matrix(i * 3, true);
                new Thread(instance.Move).Start();
            }
        }
    }
}
