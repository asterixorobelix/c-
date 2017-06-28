/*
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car.
Create several Car objects and assign different colours to them.

Also, make sure that the color variable will be returned in uppercase characters, since we apply the ToUpper() method to it

Sample Output:
This car is RED
This car is GREEN
*/
using System;

class Car{
	
	private string _colour;
	
	public string colour{
		
		get{return _colour.ToUpper();}
		
		set
		{
			_colour= value;			
		}
	}
	
	Car(string c){
		this._colour=c;
	}
	
	public void Describe(){
		Console.WriteLine("The colour of this car is: "+colour);
	}
	
	static void Main(){
		Car Beetle = new Car("Red");
		
		Beetle.Describe();
		
		Car Porsche = new Car ("Green");
		
		Porsche.Describe();
	}
}
