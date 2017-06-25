/*Write a program which asks the user to enter a radius. The program then calculates the area of the circle and prints it out.
Make sure that the area which is printed out only has two decimal places.
Don't worry about error handling.

Sample Output:
Enter a circle radius:
13
The area is 530.93 units squared
*/
using System;

class CircleArea{
	static double CalculateArea(double radius){
		return Math.Round(Math.PI*(Math.Pow(radius,2)),2);//Pi is available in the Math.PI constant
		//Math.Round(FVal, FDigits) Rounds a double-precision floating-point value (FVal) to a specified number of fractional digits (FDigits).
        //Math.Pow(base, exponent)
	}

	static void Main(){

		Console.WriteLine("Enter a circle radius:");
		double Radius =double.Parse(Console.ReadLine());

		double CircleArea = CalculateArea(Radius);

		Console.WriteLine("The area is {0} units squared",CircleArea);
	}
}