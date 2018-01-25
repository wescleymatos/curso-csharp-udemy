using System;
using System.Threading;

namespace ThreadFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadRepeticao);
            t.Start();

            for (int i = 0; i >= 1000 ; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i >= 1000 ; i++)
            {
                Console.WriteLine("ThreadRepeticao: " + i);
            }
        }
    }
}
