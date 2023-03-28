using System;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        Cal(x1,y1,x2,y2,x3,y3);
    }

    static void Cal(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double a = 2 * (x2 - x1);
        double b = 2 * (y2 - y1);
        double c = (x2 * x2) + (y2 * y2) - (x1 * x1) - (y1 * y1);
        double d = 2 * (x3 - x2);
        double e = 2 * (y3 - y2);
        double f = (x3 * x3) + (y3 * y3) - (x2 * x2) - (y2 * y2);

        double h = (b * f - e * c) / (b * d - e * a);
        double k = (d * c - a * f) / (b * d - e * a);
        double r = Math.Sqrt((x1 - h) * (x1 - h) + (y1 - k) * (y1 - k));
       
        Console.WriteLine("{0:F2}", h);
        Console.WriteLine("{0:F2}", k);
        Console.WriteLine("{0:F2}", r);
    }
}