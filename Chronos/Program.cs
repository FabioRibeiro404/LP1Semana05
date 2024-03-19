using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch chrono1 = new Stopwatch();
            Stopwatch chrono2 = new Stopwatch();

            chrono1.Start();
            Thread.Sleep(600);
            chrono2.Start();
            Thread.Sleep(200);

            chrono1.Stop();
            TimeSpan ts1 = chrono1.Elapsed;

            chrono2.Stop();
            TimeSpan ts2 = chrono2.Elapsed;

            Console.WriteLine($"Time 1: {ts1.Seconds},{ts1.Milliseconds:d3}");

            Console.WriteLine($"Time 2: {ts2.Seconds},{ts2.Milliseconds:d3}");
        }
    }
}
