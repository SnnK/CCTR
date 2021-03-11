using System;

namespace CCTR
{
    static class Cctr
    {
        public static double Operation(Interval interval)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            DateTimeOffset dt = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            int intervalValue = IntervalValue.Get(interval);

            double sCurrentTime;

            if (interval == Interval.w1)
            {
                dt = DateTimeOffset.Now.StartOfWeek(DayOfWeek.Monday);
            }
            else if (interval == Interval.M1)
            {
                dt = new DateTime(now.Year, now.Month, 1);
            }

            sCurrentTime = (double)(now.ToUnixTimeSeconds() - dt.ToUnixTimeSeconds()) / 60;

            return intervalValue - (sCurrentTime % intervalValue);
        }

        private static DateTime StartOfWeek(this DateTimeOffset dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
