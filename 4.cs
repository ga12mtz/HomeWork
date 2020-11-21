using System.IO;
using System;

class Program
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        if (D == 0)
        {
            double x1 = (-b) / (2 * a);
            Console.WriteLine(x1);
        }
        if (D < 0)
        {
            Console.WriteLine("KORNEY NET");
        }
    }
}
