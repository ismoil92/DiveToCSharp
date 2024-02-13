namespace DiveToCSharp;

public class Calculate
{
    public static double Sum(double x, double y) => x + y;
    public static double Subtract(double x, double y) => x - y;
    public static double Multiply(double x, double y) => x - y;
    public static double Divide(double x, double y)
    {
        if (y == 0)
            throw new ArgumentException("Знаменатель не должно быть 0");
        return x / y;
    }
}