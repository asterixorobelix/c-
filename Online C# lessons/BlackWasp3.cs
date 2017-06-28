/*
http://www.blackwasp.co.uk/CSharpClassProperties.aspx\
Create a Rectangle class. Add two private integer variables to the Rectangle class to hold the height and width.
Add width and height properties.
For both the width and height properties, if the value is negative or is greater than one hundred, an exception will be thrown and the property will remain unchanged.
Create two objects based upon the Rectangle class, Rect and square.
Ask the user to input width and height for these two objects and print out the widths and heights for the two.
Add read-only properties for the area and perimeter of the rectangle.
Print out the area and perimeter of the two shapes. 
*/
using System;

class Rectangle
{
    private int _width;
    private int _height;
	
	public int Width
	{
		get
		{
			return _width;
		}
		set
		{
			if (value < 0 || value > 100)
			{
				Console.WriteLine("Input is outside of range");
			}
	 
			_width = value;
		}
	}
	
	public int Height
	{
		get
		{
			return _height;
		}
		set
		{
			if (value < 0 || value > 100)
			{
				Console.WriteLine("Input is outside of range");
			}
	 
			_height = value;
		}
	}
	
	public int Area 
	//the Area property, the source of the height and width values has been disassociated from the internal variables. 
	//If the Height and Width properties are changed in the future to retrieve their values from a database, no changes to the Area property will be required.
	{
		get
		{
			return Height*Width;
		}
	}
	 
	public int Perimeter
	{
		get
		{
			return 2 * (Height+Width);
		}
	}
	
	static void Main()
	{
		Rectangle rect = new Rectangle();
		
		Console.WriteLine("Enter rectangle width:");

		rect.Width = int.Parse(Console.ReadLine());
		
		
		Console.WriteLine("Enter rectangle height:");
		
		rect.Height = int.Parse(Console.ReadLine());
		
		 
		Rectangle square = new Rectangle();
		
		Console.WriteLine("Enter square height:");
		square.Height = square.Width = int.Parse(Console.ReadLine());
		 
		Console.WriteLine("Rectangle Height: "+rect.Height);         // Outputs "25"
		Console.WriteLine("Square Width: "+square.Width);        // Outputs "40"
		 
		//rect.Height = 125;                      // Throws the validation exception.
		
		Console.WriteLine("Rectangle Area: "+rect.Area);           // Outputs "96"
		Console.WriteLine("Rectangle perimeter: "+rect.Perimeter);      // Outputs "40"
	}
}