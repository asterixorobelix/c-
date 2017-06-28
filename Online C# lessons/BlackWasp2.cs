/*
http://www.blackwasp.co.uk/CSharpSimpleClass_2.aspx
Create a class called Vehicle. Add new method called PressHorn to the vehicle class for pressing a vehicle's horn.
Create a new vehicle object and run its PressHorn method to see the results. 
*/
using System;

class Vehicle{
	
	void PressHorn(){
		Console.WriteLine("Beep");
	}
	
	static void Main (){
		Vehicle Beetle = new Vehicle();
		Beetle.PressHorn();
	}
}