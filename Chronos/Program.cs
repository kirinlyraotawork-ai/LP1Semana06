using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //namespace (declarar e instanciar os cronómetros)
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();
            //começarr a contar o tempo
            cron1.Start();
            Thread.Sleep(500);
            cron2.Start();
            Thread.Sleep(250);
            //parar de contar o tempo
            cron1.Stop(); 
            cron2.Stop();

            TimeSpan ts1 = cron1.Elapsed;
            TimeSpan ts2 = cron2.Elapsed;

            Console.WriteLine($"{cron1.Elapsed.TotalSeconds:F4}");
            Console.WriteLine($"{cron2.Elapsed.TotalSeconds:F4}");
            //4 casas decimais, por isso o F4
            //Elapsed total seconds mostra o tempo decorrido em segundos
        }
    }
}
