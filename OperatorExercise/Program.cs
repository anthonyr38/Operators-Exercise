using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);


            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

        }
        
        public static double AreaOfCircle(double radius)
        {
            var area = (Math.PI * radius * radius);
            return area;
        }
            
    }
}
