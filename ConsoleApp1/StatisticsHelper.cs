namespace ConsoleApp1;
public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        int sum = 0;
        foreach (int v in values)
            sum += v;
        return (double)sum / values.Length;
    }
    
    public static int CalculateMin(int[] values)
    {
        int min = values[0];
        foreach (int v in values)
            if (v < min) min = v;
        return min;
    }
}