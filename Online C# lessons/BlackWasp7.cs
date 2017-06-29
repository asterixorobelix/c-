/* 
http://www.blackwasp.co.uk/CSharpMethodOverloading.aspx 
Create a new class file named "Calculate"
Add a method called Square, which calculates the square of an integer value.
In order to support the double data type we can add a second variation of the method to the Calculate class. This overloaded method will accept and return doubles rather than integers. 

Sample Output:
Calculating square of an integer: 16
Calculating square of a double: 6,25
Calculating square of a double: 25
 */

using System;

class Calculate{
	
	static int Square(int v){
		Console.WriteLine("Calculating square of an integer: {0}", v*v);
		return v*v;
	}
	
	static double Square(double v){
		Console.WriteLine("Calculating square of a double: {0}", v*v);
		return v*v;
	}
	
	static void Main(){
		Square(4);
		Square(2.5);
		Square((float)5); //where an implicit cast is possible, the compiler will perform this conversion automatically. Although no overloaded method exists for floats the double variation is used instead.
	}
}