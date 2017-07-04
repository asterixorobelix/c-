/* (RectangleOverload)
http://www.blackwasp.co.uk/ConstructorOverloading.aspx
Create a Rectangle class. 
Add width and height properties.
Create overloaded constructors, so that a different constructor is called if a rectangle or a square is being created.
Create two objects based upon the Rectangle class, Rect and square.
Print out the widths and heights for the two objects.

Sample Output:
Rectangle Constructor Called
Height: 4
Width: 6
Square Constructor Called
Height: 5
Width: 5
 */
 using System;
 
 namespace RectangleOverload{
	 
	class Rectangle{
		 
		public int Height{get;set;}
		public int Width{get;set;}
			 
		internal Rectangle(int h, int w){
			 Height=h;
			 Width=w;
			 Console.WriteLine("Rectangle constructor called");
		}
		
		internal Rectangle(int h){
			Height=Width=h;
			Console.WriteLine("Square Constructor called");
		}
	 
	 /*OR
		Rectangle(int h):this(h,h){ //If only one instantiating argument is given, overloaded constructor will call other Rectangle constructor with the arguments (h,h). The constructor indicated in the this command is then executed.
			Console.WriteLine("Square Constructor called");
		}
		*/
	}
}