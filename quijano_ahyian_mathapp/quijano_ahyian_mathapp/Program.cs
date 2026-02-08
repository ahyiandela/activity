using System;

namespace MathApp
{
    class Mathprogram
    {
        static void Main(string[] args)
        {
            double number = -9.75;
            double baseNumber = 4;
            double exponent = 2;
            double decimalvalue = 6.3;

            double absoluteValue = Math.Abs(number);
            double squareroot = Math.Sqrt(absoluteValue);
            double powerResult = Math.Pow(baseNumber, exponent);
            double roundedVAlue = Math.Round(decimalvalue);
            double cellingValue = Math.Ceiling(decimalvalue);
            double floorValue = Math.Floor(decimalvalue);

            Console.WriteLine("Math Class");
            Console.WriteLine("Absolute Value: " + absoluteValue);
            Console.WriteLine("Square root: " + squareroot);
            Console.WriteLine("Power Result: " + powerResult);
            Console.WriteLine("Rounded Value: " + roundedVAlue);
            Console.WriteLine("Ceiling Value: " + cellingValue);
            Console.WriteLine("Floor Value: " + floorValue);

            Console.ReadLine();


        }
    }
}