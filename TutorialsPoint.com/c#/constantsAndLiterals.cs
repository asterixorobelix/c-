using System;

namespace DeclaringConstants
{
    class Program
    {
        static void Main()
        {
            const double pi = 3.14159;   
            
            // constant declaration 
            double r;
            
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            
            double areaCircle = pi * r * r;
            
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);//Here the first parameter is a literal which has N substitution positions. 
            //The next N parameters are inserted into those positions.
            Console.ReadLine();
        }
    }
}