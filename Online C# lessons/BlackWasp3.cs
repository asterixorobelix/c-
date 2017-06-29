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
		get{return _height;}
		set{
			if(value>=0&&value<100){
				_height=value;
			}
			else{
				Console.WriteLine("input is out of range");
			}
		}
	}
	
	public int Width{
		get{return _width;}
		set{
			if(value>=0&&value<100){
				_height=value;
			}
			else{
				Console.WriteLine("input is out of range");
			}
		}
	}
	
	public int Area{
		get{return _height*_width;}
	}
	
	public int Perimeter{
		get{return 2*(_height+_width);}
	}
	
	Rectangle(int h, int w){
		_height=h;
		_width=w;
		
		if(h==w){
			Console.WriteLine("\nSquare!");
		}
		
		Console.WriteLine("Area:"+this.Area);
		Console.WriteLine("Perimeter: "+this.Perimeter);
	}
	
	static void Main(){
		Rectangle Rect = new Rectangle(25,100);
				
		Rectangle Square = new Rectangle(25,25);
	}
}