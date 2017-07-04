/*(Car)
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car.

Create another class called Program which creates several Car objects and assigns different colours to them.

Sample Output:
This car is Red
This car is Green
*/

using System;

namespace cSharpTut
{
    internal class Car
    {
		//private variable(field)
        private string _color;

		//public property
        public string Color
        {
            get;set;
        }
		
		//constructor
        public Car(string c)
        {
            Color = c;
        }

		//Describe method
        internal void Describe()
        {
            Console.WriteLine("Colour: {0}", Color);
        }
    }
}