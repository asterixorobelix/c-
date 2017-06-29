/*
http://www.blackwasp.co.uk/CSharpConstructors.aspx
Create a new class to represent a triangular shape, called Triangle. This class will define three properties: the triangle's height, base-length and area.
In order to ensure that all triangles will have a height and base-length within the valid range, make the class's default constructor set both of these properties to one unit for all new Triangle objects.

Sample Output:
Triangle constructor executed
Area:   0,5
*/
using System;

class Triangle{
	
	private float _height;
	private float _base;
		
	public float Height{
		get{return _height;}
		set{_height=value;}
	}
	
	public float Base{
		get{return _base;}
		set{_base=value;}
	}
	
	public float Area{//read only
		get{return (float)0.5*Base*Height;}
	}
	
	Triangle(){
		Console.WriteLine("Triangle default constructor executed");
		Height=Base=1;
	}
	
	static void Main(){
		Triangle Tri = new Triangle();
		Console.WriteLine("Area: "+Tri.Area);
	}
}