/*Write a program which asks the user to enter a radius. The program then calculates the area of the circle and prints it out.
Make sure that the area which is printed out only has two decimal places.

Sample Output:
Enter Radius
13

Radius: 13, Area: 530.93
*/

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
            
            //double areaCircle = pi * r * r;
            //OR
            double areaCircle = pi*Math.Pow(r,2);//Math.Pow(base, exponent)
            
            Console.WriteLine("Radius: {0}, Area: {1:0.00}", r, areaCircle);//Here the first parameter is a literal which has N substitution positions. 
            //The next N parameters are inserted into those positions.
        }
    }
}