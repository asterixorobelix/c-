/*
http://www.blackwasp.co.uk/CSharpSimpleClass_2.aspx
Create a class called Vehicle.
Create a new vehicle object and run its ToString method to see the results. As we have not yet defined how ToString should work, this will simply show the fully qualified name.
Add a new methodto the vehicle class for pressing a vehicle's horn
*/
using System;

namespace ClassTest
{
    class Vehicle
    {
		public void PressHorn()
		{
			Console.WriteLine("Toot toot!");
		}
		
		static void Main()
		{
			Vehicle car = new Vehicle();
			Console.WriteLine(car.ToString()); // Outputs "ClassTest.Vehicle"
			car.PressHorn(); // Outputs "Toot toot!"
		}
    }
}
