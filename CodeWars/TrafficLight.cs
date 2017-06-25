/*
Create a program to demonstrate how to limit the state of TrafficLight to only Red, Green and Orange.
*/

using System;

class TLight{
	enum Lights{
		Red,Green,Orange
	};

	static void Main(){
		Console.WriteLine("The colour of the TrafficLight is:");
		//create something called TLights of type Lights and set it to Lights.Red;
		Lights TrafficLight= Lights.Red;

		TLights= Lights.Blue; //creates a compile time error: error CS0117: 'TrafficLight.Lights' does not contain a definition for 'Blue'

		Console.WriteLine(TrafficLight);
	}
}