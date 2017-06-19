/*
Julio Cesar Chavez Mark VII is an interplanetary space boxer, who currently holds the championship belts for various weight categories on many different planets within our solar system. 
However, it is often difficult for him to recall what his "target weight" needs to be on earth in order to make the weight class on other planets. 
Write a program to help him keep track of this.

It should ask him what his earth weight is, and to enter a number for the planet he wants to fight on. It should then compute his weight on the destination planet based on the table below:

#	Planet	Relative gravity
1	Venus	0.78
2	Mars	0.39
3	Jupiter	2.65
4	Saturn	1.17
5	Uranus	1.05
6	Neptune	1.23
So, for example, if Julio weighs 128 lbs. on earth, then he would weigh just under 50 lbs. on Mars, since Mars' gravity is 0.39 times earth's gravity. (128 * 0.39 is 49.92)


Our Input	Expected Output	
80 1		62.4
*/

using System;

class CalculateWeight{
	static void Main(){

		double Weight;
		int PlanetID;

		Console.WriteLine("Enter your weight on Earth:");
		double.TryParse(Console.ReadLine(),out Weight);

		Console.WriteLine("Choose destination planet. Enter 1 for Venus, 2 for Mars, 3 for Jupiter, 4 for Saturn, 5 for Uranus, 6 for Neptune:");
		int.TryParse(Console.ReadLine(),out PlanetID);

		switch (PlanetID){
			case 1:
				Console.WriteLine("Your target weight on Venus is {0} kg", Weight*0.78);
				break;
			case 2: 
				Console.WriteLine("Your target weight on Mars is {0} kg", Weight*0.39);
				break;
			case 3:
				Console.WriteLine("Your target weight on Jupiter is {0} kg", Weight*2.65);
				break;
			case 4:
				Console.WriteLine("Your target weight on Saturn is {0} kg", Weight*1.17);
				break;
			case 5:
				Console.WriteLine("Your target weight on Uranus is {0} kg", Weight*1.05);
				break;
			case 6:
				Console.WriteLine("Your target weight on Neptune is {0} kg", Weight*1.23);
				break;

			default:
				Console.WriteLine("That planet ID was not recognized, sorry");
				break;
		}

	}
}