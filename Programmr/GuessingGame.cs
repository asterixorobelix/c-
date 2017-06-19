/*
Write a program which picks a random number from 1-100. The user keeps guessing as long as their guess is wrong, and they've guessed less than 7 times. 
If their guess is higher than the number, say "Too high" if their guess is lower than the number, say "Too low". 
When they get it right, the game stops. Or, if they hit seven guesses, the game stops even if they never got it right. 

I am thinking of a number between 1-100. You have 7 guesses:
Guess #1:50
Too high
Guess #2:15
Too low
Guess #3:18
Correct. You won!
*/

using System;

class GuessNumber{
	static void Main(){

		Console.WriteLine("I am thinking of a number between 1-100. You have 7 guesses");

		int UserEntry;
		int GuessingRound=7;

		Random Rand = new Random(); //Initializes a new instance of the Random class, using a time-dependent default seed value.
		int TargetNumber=Rand.Next(1,100);//Next(Int32, Int32) Returns a random integer that is within a specified range.

		while(GuessingRound>0){
			Console.WriteLine("Enter your guess:");
			int.TryParse(Console.ReadLine(),out UserEntry);

			if(UserEntry<TargetNumber){
				Console.WriteLine("Too low!");
			}

			else if(UserEntry>TargetNumber){
				Console.WriteLine("Too high!");
			}

			else if(UserEntry==TargetNumber){
				Console.WriteLine("You won!");
				return;
			}

			GuessingRound--;
		}

		if (GuessingRound==0){
			Console.WriteLine("You lost! I was thinking of the number: {0}",TargetNumber);
		}
	}
}

