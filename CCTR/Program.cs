using System;
using System.Threading;

namespace CCTR
{
    class Program
    {
        static void Main()
        {
            int cctrValueMin = (int)Math.Ceiling(Cctr.Operation(Interval.m15, TimeFormat.minute)); // 15-Minute chart

            Console.WriteLine($"After {cctrValueMin} minutes the candlestick will close.");

            while (true)
            {
                int cctrValueSec = (int)Cctr.Operation(Interval.m15, TimeFormat.second);

                Console.WriteLine($"After {cctrValueSec} seconds the candlestick will close.");
                Thread.Sleep(1000);
            }
        }
    }
}
