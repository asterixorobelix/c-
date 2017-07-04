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
	
	class Mass{
		
		public double Density{
			set;get;
		}
		
		public double Volume{
			set;get;
		}
		
		internal Mass(double d,double v){
			Density=d;
			Volume=v;
		}
		
		public static int Count{//Count is automatically initialized to zero
			get;
			set;
		}
		
		public void MassCalculator(){
			Count++;
			Console.WriteLine("Mass = {0} units",Density*Volume);
		}
	}
}