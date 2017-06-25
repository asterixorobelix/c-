/*
Write a program which asks the user for a measurement in feet and returns the answer in inches.
One foot is 12 inches.
Include error handling.

Sample Output:
Enter a measurement in Feet to convert to Inches:
35.43
35.43 feet is 425.16 inches

C:\Users\8460p\Desktop\practice>Practice.exe
Enter a measurement in Feet to convert to Inches:
a
Invalid input
*/

using System;

class Convert{
	static double ConvertingFeetToInches(double feet){
		return feet*12;
	}

	static void Main(){
		double UserFeet;

		Console.WriteLine("Enter a measurement in Feet to convert to Inches:");

		try{
			UserFeet=double.Parse(Console.ReadLine());
			double Inches = ConvertingFeetToInches(UserFeet);

			Console.WriteLine("{0} feet is {1} inches",UserFeet,Inches);
		}

		catch{
			Console.WriteLine("Invalid input");
		}
	}
}