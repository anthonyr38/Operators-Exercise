using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int add = 1 + 1;
            int subtract = 1 - 1;
            int multiply = 1 * 1;
            int divide = 1 / 1;
            int modulo = 1 % 1;

            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //Exerceise 2

            Console.WriteLine(“What is the radius of your circle ?”);
            var userInput = Console.ReadLine();

            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine();

            AreaOfCircle(radius);

            Console.WriteLine($"A circle with a radius of {radius} has an area of {AreaOfCircle()}");


            //Thought Exercise
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

            /*
            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);


            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
            */

        }
        
        public static double AreaOfCircle(double radius)
        {
            var area = (Math.PI * Math.Pow(radius, 2);

            return area;
        }
        
            
    }
}
