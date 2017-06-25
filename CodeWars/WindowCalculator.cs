/*
Write a program which reads in the width and height (as doubles) of a hole in the wall for a window.
The program should then print out the amount of wood required for the frame (in metres) and glass required to double glaze a window of that size.
Include input validation in your solution.
Use passing parameters as output for a function called Calculating which does the actual calculations.

Sample Output:
Enter the width of the window in meters:
a
Invalid Input
Enter the width of the window in meters:
2.1
Enter the height of the window in meters:
1
The length of wood required for a window that size is 6.2 m
The area of glass required for a window that size is 4.2 m
*/

using System;

class WindowCalculate{

	static void Calculating (double width, double height, out double WoodLength, out double GlassArea){

		WoodLength=Math.Round((2*height+2*width),2);

		GlassArea=Math.Round(2*(height*width),2);
	}

	static double VerifyInput (string Message){

		bool Invalid = true;
		double IntInput = 0;

		while(Invalid){
			Console.WriteLine(Message);

			try{
				string Input=Console.ReadLine();
				IntInput=double.Parse(Input);

				Invalid=false;
			}

			catch{
				Console.WriteLine("Invalid Input");
			}
		}
		return IntInput;
	}

	static void Main(){
		string Msg="Enter the width of the window in meters:";

		double UserWidth=VerifyInput(Msg);

		Msg="Enter the height of the window in meters:";

		double UserHeight = VerifyInput(Msg);

		double CalculatedWoodLength, CalculatedGlassArea;

		Calculating(UserWidth,UserHeight,out CalculatedWoodLength,out CalculatedGlassArea);

		Console.WriteLine("The length of wood required for a window that size is {0} m",CalculatedWoodLength);
		Console.WriteLine("The area of glass required for a window that size is {0} m^2",CalculatedGlassArea);
	}
}