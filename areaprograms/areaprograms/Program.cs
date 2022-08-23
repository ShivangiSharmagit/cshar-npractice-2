using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaprograms
{
    internal class Program
    {

         static void Main(string[] args)
        {
            Start:
            Console.WriteLine("enter following number for area of  \n 1: Reactangle \n 2: Square \n 3: Triangle \n 4: Cone \n 5: circle ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine(rectangle.GetArea());
                    break;
                case 2:
                    Square s1 = new Square();
                    Console.WriteLine(s1.GetArea());
                    break;
                case 3:
                    triangle triangle = new triangle();
                    Console.WriteLine(triangle.GetArea());
                    break;
                case 5:
                    Circle circle = new Circle();
                    Console.WriteLine(circle.GetArea());
                    break;
                case 4:
                    Cone cone = new Cone();
                    Console.WriteLine(cone.GetArea());
                    break;
            }
            Console.WriteLine(" \n wants to try again ,write yes or no");
            string s = Console.ReadLine();
            s = s.ToLower();
            if (s == "yes")
            {
                goto Start;
            }

            Console.ReadKey();

        }
    }
        public  abstract class Shape
        {
        public double height;
        public double width;
        public double radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
      
        }
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Console.Write("Enter the Length of a Rectangle: ");
             height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Breadth of a Rectangle: ");
             width = Convert.ToInt32(Console.ReadLine());
        }
        public override double GetArea()
        {
            Console.Write($"Area of width {width} and height {height} Rectangle is :");

            return height * width;
        }
    }
    public class Square : Shape
    {
        public Square()
        {
            Console.Write("Enter the side of a square: ");
            height = Convert.ToInt32(Console.ReadLine());
           
        }
        public override double GetArea()
        {
            Console.Write($"Area of side {height} square is :");
            return height * height;
        }
    }
    public class Circle : Shape
    {
        public Circle()
        {
            Console.Write("Enter the radius of a Circle: ");
             radius = Convert.ToInt32(Console.ReadLine());
          
        }
        public override double GetArea()
        {
            Console.Write($"Area of radius {radius}  circle is :");
            return Pi * radius * radius;
        }
    }
    public class triangle : Shape
    {
        public triangle()
        {
            Console.Write("Enter the width of a triangle: ");
             width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of a triangle: ");
             height = Convert.ToInt32(Console.ReadLine());
        }
        public override double GetArea()
        {
            Console.Write($"Area of width {width} and height {height} triangle is :");
            return (width * height) / 2;
        }
    }
    public class Cone : Shape
    {
        public Cone()
        {
            Console.Write("Enter the radius of a Cone: ");
             radius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of a Cone: ");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public override double GetArea()
        {
            Console.Write($"Area of radius {radius} and height {height} Cone is :");
            return Pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }
    }
}
