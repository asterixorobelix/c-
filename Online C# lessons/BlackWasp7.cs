/* 
http://www.blackwasp.co.uk/CSharpMethodOverloading.aspx 
Create a new class file named "Calculate"
Add a method called Square, which calculates the square of an integer value.
In order to support the double data type we can add a second variation of the method to the Calculate class. This overloaded method will accept and return doubles rather than integers. 

Sample Output:
Double Square calculated
25
Integer Square calculated
25
Double Square calculated
25
 */


using System;

namespace CSharpMethodOverloading
{
	class Program
    {
		class Calculate
		{
			public static int Square(int number)
			{
				Console.WriteLine("Integer Square calculated");
				return number * number;
			}
			
			public static double Square(double number)
			{
				Console.WriteLine("Double Square calculated");
				return number * number;
			}
		}
		
        static void Main(string[] args)
        {
            double squareMe = 5;
            int squareMeToo = 5;
            Console.WriteLine(Calculate.Square(squareMe));
            Console.WriteLine(Calculate.Square(squareMeToo));

            float squareMeThree = 5;
            Console.WriteLine(Calculate.Square(squareMeThree)); //where an implicit cast is possible, the compiler will perform this conversion automatically. Although no overloaded method exists for floats the double variation is used instead.
        }
    }
}
