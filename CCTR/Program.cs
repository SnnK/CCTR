using System;

namespace CCTR
{
    class Program
    {
        static void Main()
        {
            int cctrValue = (int)Math.Ceiling(Cctr.Operation(Interval.m15)); // 15-Minute chart

            Console.WriteLine($"After {cctrValue} minutes the candlestick will close.");
        }
    }
}
