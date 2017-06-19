/*
Write a method to compute the distance between two points. Given two points (x1, y1) and (x2, y2), the distance between these points is given by the formula:
d=((x2-x1)^2+(y2-y1)^2)^0.5

You must name the method distance, and it must return a decimal giving the distance between the two points.
Tests:
Our Input (x1,y1,x2,y2)	Expected Output					Your code's output
0 0 0 0					distance = 0					distance = 0
-2 1 1 5				distance = 5					distance = 5
-2 -3 -4 4				distance = 7.28010988928052		distance = 7.28010988928052
*/

using System;

class DistanceFormula{
	static void Main(){
		double x1,x2,y1,y2;
		double CalculatedDistance;

		Console.WriteLine("Enter a value for x1:");
		double.TryParse(Console.ReadLine(),out x1);
		//Console.WriteLine("The value of x1: {0}",x1);

		Console.WriteLine("Enter a value for x2:");
		double.TryParse(Console.ReadLine(),out x2);

		Console.WriteLine("Enter a value for y1:");
		double.TryParse(Console.ReadLine(),out y1);

		Console.WriteLine("Enter a value for y2:");
		double.TryParse(Console.ReadLine(),out y2);

		CalculatedDistance=CalculateDistance(x1,x2,y1,y2);

		Console.WriteLine("The distance is {0}",CalculatedDistance);


	}

	static double CalculateDistance(double d1,double d2,double e1,double e2){
		double a,b,c;
		a=d2-d1;
		b=e2-e1;

		c=Math.Pow(a,2)+Math.Pow(b,2);
		Console.WriteLine("c:{0}",c);


		double distance =Math.Sqrt(c);
		return distance;
	}
}