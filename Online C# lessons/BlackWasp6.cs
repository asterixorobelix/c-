/* 
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

class MassCalculator{
	private double _density;
	private double _volume;
	private static int _count;//want _count to be independent of how many objects have been instantiated
	
	public double Density{
		get{return _density;}
		set{_density=value;}
	}
	
	public double Volume{
		get{return _volume;}
		set{_volume=value;}
	}
	
	public static int Count{
		get{return _count;}
	}
	
	MassCalculator(){
		_count=0;
	}
	
	public double CalculateMass(double d, double v){
		++_count;
		Console.WriteLine("Mass: "+d*v);
		return  d*v;
	}
	
	static void Main(){
		MassCalculator Calc = new MassCalculator();
		
		Calc.CalculateMass(23,56);
		Calc.CalculateMass(1245.2,45.6);
		Calc.CalculateMass(145.2,45.6);
		
		int CalcCount=MassCalculator.Count;
		
		Console.WriteLine("Calculator has been used {0} times",CalcCount);
	}
}