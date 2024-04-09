using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            
            double circleArea = circle.GetArea();
            Console.WriteLine("Площа кола: " + circleArea); 

            
            circle.Scale(2);

           
            circleArea = circle.GetArea();
            Console.WriteLine("Площа кола після масштабування: " + circleArea);

            
            Rectangle rectangle = new Rectangle(4, 3);

            
            double rectangleArea = rectangle.GetArea();
            Console.WriteLine("Площа прямокутника: " + rectangleArea); 

            
            rectangle.Scale(1.5);

            
            rectangleArea = rectangle.GetArea();
            Console.WriteLine("Площа прямокутника після масштабування: " + rectangleArea); 
            Console.ReadLine();
        }
    }
    public interface IScalable
    {
        void Scale(double s);
    }

    public class Circle : IScalable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Scale(double s)
        {
            radius *= s;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : IScalable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void Scale(double s)
        {
            width *= s;
            height *= s;
        }

        public double GetArea()
        {
            return width * height;
        }
    }

}
