/*
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car.
Create several Car objects and assign different colours to them.
The color variable will now be returned in uppercase characters, since we apply the ToUpper() method to it before returning it, and when we try to set the color, only the value "Red" will be accepted.

Sample Output:
This car is Red
This car is Green
*/

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Car car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Green");
            Console.WriteLine(car.Describe());
        }
    }

    class Car
    {
        private string color;

        public string Color
		{
			get 
			{
				return color.ToUpper(); 
			}
			set 
			{ 
				if(value == "Red")
					color = value; 
				else
					Console.WriteLine("This car can only be red!");
			}
		}

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
	}
}

