/*
Write a method called AjustForInflation, which takes two inputs, which represent the value of a home and an income.
The method should then adjust these values by an inflation rate of 1.0345. 
The method should then return these values so that they may be printed to the screen.
 
Sample Output:
Values after inflation: House: 20690, Income: 7758,75
*/

using System;

namespace ConsoleApplication{
	class Program{
		static void Main(){
			float house = 20000;
			float salary= 7500;
			
			AdjustForInflation (ref house, ref salary);
			Console.WriteLine("Values after inflation: House: {0}, Income: {1}",house, salary);
		}
		static void AdjustForInflation (ref float home, ref float income){
			const float RATE=1.0345f;
			home *=RATE;
			income *= RATE;
		}
	}
}