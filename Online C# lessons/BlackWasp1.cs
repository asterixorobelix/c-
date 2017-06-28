/*
http://www.blackwasp.co.uk/CSharpSimpleClass.aspx
Create a class called Vehicle.
Create a new vehicle object and run its ToString method to see the results. As we have not yet defined how ToString should work, this will simply show the fully qualified name.

*/
using System;

namespace ClassTest
{
    class Vehicle
    {
		static void Main()
		{
			Vehicle car = new Vehicle();
			Console.WriteLine(car.ToString());  // Outputs "ClassTest.Vehicle"
		}
    }
}
