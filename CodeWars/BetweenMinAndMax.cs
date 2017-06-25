/*
Create a method called ReadValue, which will continue to prompt a user to enter a value between a min and a max, with a configurable message.
Sample Output:
Enter your age  between 0 and 100
120
Enter your age  between 0 and 100
Twelve
Invalid input
Enter your age  between 0 and 100
55
*/

using System;

class ErrorValidator{
	static double ReadValue(double max, double min, string Message){

		bool IsValid = false;
		double Result = 0;

		while (!IsValid){
			Console.WriteLine("{0} between {1} and {2}",Message, min, max);

			try{

				Result=double.Parse(Console.ReadLine());

				if(Result>min&&Result<max){
					IsValid=true;
				}				
			}

			catch{
				Console.WriteLine("Invalid input");
			}
		}
		return Result;
	}


	static void Main(){
		const double MAX = 100;
		const double MIN=0;

		string MSG="Enter your age ";

		double UserEntry = ReadValue(MAX,MIN,MSG);

	}
}