/*
http://www.blackwasp.co.uk/CSharpConstructors.aspx
Create a new class to represent a triangular shape, called Triangle. This class will define three properties: the triangle's height, base-length and area.
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
                throw new OverflowException();
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
                throw new OverflowException();
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
	 
		Console.WriteLine("Height:\t{0}", triangle.Height);
		Console.WriteLine("Base:\t{0}", triangle.BaseLength);
		Console.WriteLine("Area:\t{0}", triangle.Area);
	}
}