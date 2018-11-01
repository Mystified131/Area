using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double radius;

            Console.WriteLine("Let's calculate the area of a circle!");
            Console.WriteLine("The radius of the circle is:");
            radius = double.Parse(Console.ReadLine());

            if (radius > 0)
            { 
            area = 3.14 * (radius * radius);

            Console.WriteLine("The area of the circle with a radius of " + radius + " is:" + area);
            Console.ReadLine();
        }
            else
            {
                Console.WriteLine("The number you entered was negative, so no calculation could be made.");
                Console.ReadLine();

            }
        }
    }
}
