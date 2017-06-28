/*
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car.
Create several Car objects and assign different colours to them.

Sample Output:
The colour of this car is: Yellow
The colour of this car is: Red
*/
using System;

class Car{
	
	private string _colour;
	
	public Car(string _c){//constructor
		this._colour=_c;
	}
	
	//properties
	public string colour{
		get{return _colour;}
		set{value =_colour;}
	}
	
	public void Describe(){
		Console.WriteLine("The colour of this car is: "+colour);
	}
	
	static void Main(){
		Car Beetle = new Car ("Yellow");
		Car Porsche = new Car ("Red");
		
		Beetle.Describe();
		Porsche.Describe();
	}
}