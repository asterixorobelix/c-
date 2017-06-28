/*
http://www.blackwasp.co.uk/CSharpConstructors.aspx
Create a new class to represent a triangular shape, called Triangle. This class will define three properties: the triangle's height, base-length and area.
In order to ensure that all triangles will have a height and base-length within the valid range, make the class's default constructor set both of these properties to one unit for all new Triangle objects.

Sample Output:
Triangle constructor executed
Height: 1
Base:   1
Area:   0,5
*/
using System;

public class Triangle
{
	public Triangle()//constructor
	{
		Console.WriteLine("Triangle default constructor executed");
	 
		_height = _baseLength = 1;
	}
	
    private int _height;
    private int _baseLength;
 
    public int Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                Console.WriteLine("Input is outside of range");
            }
 
            _height = value;
        }
    }
 
    public int BaseLength
    {
        get
        {
            return _baseLength;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                Console.WriteLine("Input is outside of range");
            }
             _baseLength = value;
        }
    }
 
    public double Area
    {
        get
        {
            return _height * _baseLength * 0.5;
        }
    }
	
	static void Main()
	{
		Triangle triangle = new Triangle();
	 
		Console.WriteLine("Height:\t{0}", triangle.Height); // \t =Horizontal tab
		Console.WriteLine("Base:\t{0}", triangle.BaseLength);
		Console.WriteLine("Area:\t{0}", triangle.Area);
	}
}