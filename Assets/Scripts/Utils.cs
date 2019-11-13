using System;
using System.Collections;
using System.Collections.Generic;


public static class Utils 
{
    public static double GetRandomDouble(double minimum, double maximum)
    {
        Random random = new Random();
        return random.NextDouble() * (maximum - minimum) + minimum;
    }
}
