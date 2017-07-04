/*(MassCalculator)
http://www.blackwasp.co.uk/CSharpStaticBehaviour.aspx
Create a class named 'MassCalculator', which multiplies density*volume. 
Provide a method which accepts the density and the volume of an item and calculates its mass. 
The class will also maintain a property which counts the number of times that the calculation has been performed. 

Sample Output:
Mass: 1288
Mass: 56781,12
Mass: 6621,12
Calculator has been used 3 times
*/
using System;

namespace Calculator{
	
	class Program{
		
		static void Main(){
			Mass m1 = new Mass(2.3,4);
			m1.MassCalculator();
			
			Mass m2 = new Mass(11,3);
			m2.MassCalculator();
			
			Console.WriteLine("Calculator has been used {0} times", Mass.Count);
		}
	}	
}