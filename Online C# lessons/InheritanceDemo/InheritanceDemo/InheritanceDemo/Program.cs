/* Add the main method test code from the article.
 * Step through the code in Visual Studio by pressing F11.
 * Use the Locals window and the console output to see the results */

using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorVehicle v = new MotorVehicle();
            Console.WriteLine("Speed: {0}mph", v.Speed);    // Outputs "Speed 0mph"
            v.Accelerate(25);
            Console.WriteLine("Speed: {0}mph", v.Speed);    // Outputs "Speed 25mph"
            v.Decelerate(15);
            Console.WriteLine("Speed: {0}mph", v.Speed);    // Outputs "Speed 10mph"
            Console.ReadLine();
            // Add sample Main method code here.
        }
    }
}
  