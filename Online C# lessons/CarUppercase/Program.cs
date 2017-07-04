/*(CarUppercase)
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car. However, make sure that the color variable will be returned in uppercase characters, since we apply the ToUpper() method to it
Create several Car objects and assign different colours to them.

Sample Output:
This car is RED
This car is GREEN
*/

namespace CarUppercase{
	
	class Program{
		
		static void Main(){
			Car Beetle = new Car("Yellow");
			Beetle.Describe();
		}
	}
}