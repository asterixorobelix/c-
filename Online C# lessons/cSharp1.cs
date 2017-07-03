/*
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car.

Create another class called Program which creates several Car objects and assign different colours to them.

Sample Output:
This car is Red
This car is Green
*/
using System;

class Car{
	public string Color{
		get;set;
	}
	
	internal Car(string col){
		Color=col;
	}
	
	internal void Describe(){
		Console.WriteLine("The colour of the car is: "+Color);
	}	
}

class Program{
	static void Main(){
		Car Porsche = new Car("Green");
		Porsche.Describe();
		
		Car Beetle = new Car("Blue");
		Beetle.Describe();
	}
}