/*
http://www.blackwasp.co.uk/CSharpClassProperties.aspx\
Create a Rectangle class. Add two private integer variables to the Rectangle class to hold the height and width.
Add width and height properties.
For both the width and height properties, if the value is negative or is greater than one hundred, display an error message and the property will remain unchanged.
Create two objects based upon the Rectangle class, Rect and square.
Ask the user to input width and height for these two objects and print out the widths and heights for the two.
Add read-only properties for the area and perimeter of the rectangle.
Print out the area and perimeter of the two shapes. 

Sample Output:
Area:2500
Perimeter: 250

Square!
Area:625
Perimeter: 100
*/
using System;

class Rectangle{
	private int _height;
	private int _width;
	
	public int Height{
		get{
			return _height;
		}
		set{
			_height= Validate(value);
		}
	}
	
	public int Width{
		get{ return _width;}
		set{
			_width=Validate(value);
		}
	}
	
	private double AreaCalc(){
		double _area=Height*Width;
		Console.WriteLine("Area: "+_area);
		return _area;
	}
	
	public int Validate(int y){
		int res;
		
		if(y>0&&y<=100){
			//Console.WriteLine("Valid input");
			res=y;
		}
		else{
			Console.WriteLine("Input outside of range. Applying default value of 1");
			res=1;				
		}
		return res;
	}
	
	
	public double Area{
		get{
			return AreaCalc();
		}
	}
	
	Rectangle(int h,int w){
		Height=h;
		Width=w;
		
		if(Height==Width){
			Console.WriteLine("Square!");
		}
	}
	
	static void Main(){
		Rectangle Rect=new Rectangle(-2,6);

		double a1 = Rect.Area;
		
		Rectangle Square=new Rectangle(2,2);
		double a2=Square.Area;
		
		Console.WriteLine("Total area: {0}",a2+a1);
	}
}