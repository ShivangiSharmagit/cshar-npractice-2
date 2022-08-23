using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SurfaceAreaAndVolume.Cuboid;

namespace SurfaceAreaAndVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("enter following number for  surface area  and volume of  \n 1: cube \n 2: cuboid \n 3: cylinder \n 4: cone");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Cube c = new Cube();
                   c.SurfaceArea();
                    Console.WriteLine( c.Volume());
                    break;
                case 2:
                    Cuboid cd = new Cuboid();
                   cd.SurfaceArea();
                    Console.WriteLine( cd.Volume());
                    break;
                case 3:
                    Cylinder cy = new Cylinder();
                    cy.SurfaceArea();
                    Console.WriteLine( cy.Volume());
                    break;
                case 4:
                    SurfaceArea();
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
    public abstract class Shape
    {

        public double Length;
        public double height;
        public double Side;
        public double width;
        public double radius;
        public const float Pi = 3.14f;
      
    }
    public interface SAV
    {
       
        void SurfaceArea();
        double Volume();
    }
    public  class Cube : Shape, SAV
    {
        public Cube()
        {
            Console.Write("Enter Side: ");
            Side = Convert.ToInt32(Console.ReadLine());

        }
        public void SurfaceArea()
        {
             double area = 6 * Side * Side;
            Console.WriteLine($"Surface Area of Cube is: {area} ");
            
        }
        public double Volume()
        {
            Console.Write("Volume of cube=");
            return Side * Side * Side;
        }

    }
    public class Cuboid : Shape, SAV
    {
        public Cuboid()
        {
            Console.Write("Enter Length of Cuboid:");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Width of Cuboid:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height of Cuboid:");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void SurfaceArea()
        {
            Console.WriteLine($"Surface Area of Cuboid is: {2 * (Length * width + width * height + height * Length)}");
        }
        public double Volume()
        {
            Console.Write("Volume of Cuboid is:");
            return height * width * Length;
        }
    }
        public class Cylinder : Shape, SAV 
        {
            public Cylinder()
            {
                Console.Write("Enter radius of Cuboid:");
                radius = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Height of Cuboid:");
                height = Convert.ToInt32(Console.ReadLine());
            }
            public void SurfaceArea()
            {
                Console.Write("Surface Area of Cuboid is:");
                Console.WriteLine($" Total Surface Area of Cylinder is:{2 * Pi * radius * height}  and Curve Surface Area is {2 * Pi * radius * (height + radius)}");
               
               
            }
            public double Volume()
            {
                Console.WriteLine("Volume of cylinder: ");
                return Pi * (radius * radius) * height;
            }

        }
        public abstract class Cone : Shape, SAV
        {
            public Cone()
            {
                Console.Write("Enter radius of Cuboid:");
             double  radiuss = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter slant height of Cuboid:");
             double slant_height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height of Cuboid:");
            double height = Convert.ToInt32(Console.ReadLine());
        }
            public abstract  void SurfaceArea();
            public void surface(double  radiuss , double slant_height)
            {
                Console.WriteLine($"Surface Area of Cone:{Pi * radiuss * radiuss + Pi * radiuss * slant_height} ");
            }
        public abstract double Volume();
        public void volumeC(double radiuss, double height)
            {
            Console.WriteLine($"Volume of Cone: {(1.0 / 3) * Pi * height * radiuss * radiuss}" );
        }

        }
    }
