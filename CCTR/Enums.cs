namespace CCTR
{
    enum TimeFormat
    {
        second, 
        minute
    }

    enum Interval
    {
        m1, m5, m15, m30, h1, h4, d1, w1, M1
    }

    static class IntervalValue
    {
        public static int Get(Interval interval)
        {
            return interval switch
            {
                Interval.m1 => 1,
                Interval.m5 => 5,
                Interval.m15 => 15,
                Interval.m30 => 30,
                Interval.h1 => 60,
                Interval.h4 => 240,
                Interval.d1 => 1440,
                Interval.w1 => 10080,
                Interval.M1 => 43200,
                _ => 0,
            };
        }
    }
}
