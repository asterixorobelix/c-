/* (RectangleOverload)
http://www.blackwasp.co.uk/ConstructorOverloading.aspx
Create a Rectangle class. 
Add width and height properties.
Create overloaded constructors, so that a different constructor is called if a rectangle or a square is being created.
Create two objects based upon the Rectangle class, Rect and square.
Print out the widths and heights for the two objects.

Sample Output:
Rectangle constructor called
Width: 4, Height: 3
Square Constructor called
Width: 3, Height: 3
 */
 using System;
 
 namespace RectangleOverload{
	 
	 class Program{
		static void Main(){
			Rectangle Rect = new Rectangle(3,4);
			 Console.WriteLine("Width: {0}, Height: {1}",Rect.Width, Rect.Height);
			 
			 Rectangle Square = new Rectangle(3);
			 Console.WriteLine("Width: {0}, Height: {1}",Square.Width, Square.Height);
		}
	}
 }