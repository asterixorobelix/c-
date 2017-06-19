using System;

class DistanceFormula{
	static void Main(){
		string x1 = "-2";
		double xnum;
		
		Console.WriteLine("The value of x1: {0}",x1);
		double.TryParse(x1,out xnum);

		Console.WriteLine("The value of x1: {0}",xnum);
	}
}