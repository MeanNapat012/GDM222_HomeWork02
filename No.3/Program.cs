using System;

class Program
{
    static void Main()
    {
        double XC1 = double.Parse(Console.ReadLine());
        double YC1 = double.Parse(Console.ReadLine());
        double XC2 = double.Parse(Console.ReadLine());
        double YC2 = double.Parse(Console.ReadLine());

        double RC1 = double.Parse(Console.ReadLine());
        double RC2 = double.Parse(Console.ReadLine());

        Cal(XC1,YC1,XC2,YC2,RC1,RC2);
    }

    static void Cal(double XC1, double YC1, double XC2, double YC2, double RC1, double RC2)
    {
        double distance = Math.Sqrt(Math.Pow(XC2 - XC1 ,2 ) + Math.Pow(YC2 - YC1, 2));

        if(distance <= RC1 + RC2)
        {
            double a = (Math.Pow(RC1, 2) - Math.Pow(RC2, 2) + Math.Pow(distance, 2)) / (2 * distance);
            double h = Math.Sqrt(Math.Pow(RC1, 2) - Math.Pow(a, 2));
            double midPointX = XC1 + (a * (XC2 - XC1)) / distance;
            double midPointY = YC1 + (a * (YC2 - YC1)) / distance;
            double VectorX = (h * (YC2 - YC1)) / distance;
            double VectorY = (h * (XC2 - XC1)) / distance;

            if(distance == RC1 + RC2)
            {
                Console.WriteLine("{0:F2}",midPointX - VectorX);
                Console.WriteLine("{0:F2}",midPointY + VectorY);

            }
            else
            {
                Console.WriteLine("{0:F2}",midPointX - VectorX);
                Console.WriteLine("{0:F2}",midPointY + VectorY);
                Console.WriteLine("{0:F2}",midPointX + VectorX);
                Console.WriteLine("{0:F2}",midPointY - VectorY);
            }
        }

    }
}