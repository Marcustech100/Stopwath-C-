using System;
using System.Threading;

namespace Stopwatch
{
    class program
    {
        static void Main(string[] args)
        {
           start(); 
        }

        static void start()
        {
            int time = 10;
            int currenTime = 0;
            
            while(currenTime != time)
            {
                Console.Clear();
                currenTime ++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);    
            }
        }
    }
}
