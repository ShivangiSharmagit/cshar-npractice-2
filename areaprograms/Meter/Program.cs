using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter following number for  converting \n 1: celsius to fahrenheit \n 2: fahrenheit to celsius \n 3: profit or loss \n 4: Convert inch to cm \n 5: perimeter of rectangle \n 6: perimeter of square");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Enter temperature in Celsius : ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = CelsiusFahrenheit(celsius);
                    Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);
                    break;
                case 2:

                    Console.WriteLine("Enter Fahrenheit Temperature:");
                    double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
                    double Celsius = FahrenheitCelsius(Fahrenheit);
                    Console.WriteLine("The converted Celsius temperature is:" + Celsius);
                    break;
                case 3:
                    Console.WriteLine("Enter Cost Price ");
                    double costPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Selling Price ");
                    double sellingPrice = Convert.ToDouble(Console.ReadLine());
                    if (sellingPrice == costPrice)
                        Console.Write("No profit nor Loss");
                    else if (sellingPrice > costPrice)
                    {
                        Console.WriteLine("Profit :" + Profit(costPrice, sellingPrice));
                    }
                    else
                    {
                        Console.WriteLine("Loss :" + Loss(costPrice, sellingPrice));
                    }
                    break;
                case 4:
                    float inch;
                    Console.WriteLine("Enter value in Inch : ");
                    inch = float.Parse(Console.ReadLine());
                    Console.WriteLine("{0} inch is equal to {1} centimeter ", inch, convert(inch));
                    break;
                case 5:
                    Console.Write("Enter the value of length : ");
                    decimal length = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter the value of width : ");
                    decimal width = Convert.ToDecimal(Console.ReadLine());
               
                    Console.Write("Perimeter of rectangle is: " + CalculatePerimeterOfRectangel(length, width));
                    break;
                case 6:
                    Console.Write("Enter the value of side : ");
                    decimal side = Convert.ToDecimal(Console.ReadLine());
                    decimal perimeter = CalculatePerimeterOfSquare(side);
                    Console.Write("Perimeter of Square is : " + perimeter);
                    break;
            }
        }
        private static double CelsiusFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
        private static double FahrenheitCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
        static double Profit(double costPrice, double sellingPrice)
        {
            double profit = (sellingPrice - costPrice);
            return profit;
        }
        static double Loss(double costPrice, double sellingPrice)
        {
            double Loss = (costPrice - sellingPrice);
            return Loss;
        }
        public static float convert(float a)
        {
            float cm1;
            cm1 = (float)(a * 2.54);
            return cm1;
        }
       static decimal  CalculatePerimeterOfRectangel(decimal length, decimal width)
        {
            decimal perimeter = 2 * (length + width);
            return perimeter;
        }
        private static decimal CalculatePerimeterOfSquare(decimal side)
        {
            return 4 * side;
        }

    }
}