using System;
using System.Threading;

namespace Stopwatch
{
    class program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto=> 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            start(time * multiplier);    
        }

        static void start(int time)
        {
            int currenTime = 0;

            while(currenTime != time)
            {
                Console.Clear();
                currenTime ++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);    
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1000);

            Menu();
        }
    }
}
