/*(Rectangle)
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

namespace ShapeClasses{
	
	class Rectangle{
		//These private fields are not used at the moment
		private int _height;
		private int _width;
		
		public int Height{
			get;set;
		}
		
		public int Width{
			get;set;
		}
		
		internal Rectangle(int h,int w){
			if(h==w){
				Console.WriteLine("Square!");
			}
			
			Height=this.Validate(h);
			Width=this.Validate(w);
		}
		
		private int Validate(int y){
			if(y>0&&y<100){
				return y;
			}
			else{
				Console.WriteLine("Invalid input. Applying default value of 1");
				return 1;
			}
		}
		
		internal void Area(){
			Console.WriteLine("The area is: {0} units squared",Height*Width);
			
		}
	}
}