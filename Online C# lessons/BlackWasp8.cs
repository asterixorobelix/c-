/* 
http://www.blackwasp.co.uk/ConstructorOverloading.aspx
Create a Rectangle class. Add two private integer variables to the Rectangle class to hold the height and width.
Add width and height properties.
For both the width and height properties, if the value is negative or is greater than one hundred, display an error message and the property will remain unchanged.
Create overloaded constructors, so that a different constructor is called if a rectangle or a square is being created.
Create two objects based upon the Rectangle class, Rect and square.
Print out the widths and heights for the two objects.
Add read-only properties for the area and perimeter of the rectangle.

Sample Output:
Rectangle Constructor Called
Height: 4
Width: 6
Rectangle Constructor Called
Square Constructor Called
Height: 5
Width: 5
 */
using System;

class Rectangle
    {
        private int _height;
        private int _width;

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
        }

        public Rectangle(int height, int width)
        {
            if (height <= 0) throw new ArgumentException("height");
            if (width <= 0) throw new ArgumentException("width");

            _height = height;
            _width = width;

            Console.WriteLine("Rectangle Constructor Called");
        }

        public Rectangle(int size) : this(size, size)
        {
            Console.WriteLine("Square Constructor Called");
        }
		
		static void Main()
        {
            Rectangle rect = new Rectangle(4, 6);
            Console.WriteLine("Height: {0}", rect.Height);
            Console.WriteLine("Width: {0}", rect.Width);

            Rectangle square = new Rectangle(5);
            Console.WriteLine("Height: {0}", square.Height);
            Console.WriteLine("Width: {0}", square.Width);
        }
    }