using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DateModifier
{
    public int CalculateDifference(string dat1, string dat2)
    {
        var dat1a = dat1.Split()
            .Select(int.Parse)
            .ToArray();

        DateTime datTime1 = new DateTime(dat1a[0], dat1a[1], dat1a[2]);

        var dat2a = dat2.Split()
            .Select(int.Parse)
            .ToArray();

        DateTime datTime2 = new DateTime(dat2a[0], dat2a[1], dat2a[2]);

        return Math.Abs((datTime1 - datTime2).Days);
    }
}