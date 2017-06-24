/*
The objective of 'Duck, duck, goose' is to walk in a circle, tapping on each player's head until one is finally chosen. 

Task: Given an array of players and an index (1-based), return the name of the chosen player. 

Sample Output:
Enter the player to be the goose:
3
Goose is player number: 3
The players are:
Nathan James Fred Sarah
The goose is: Fred

Enter the player to be the goose:
6
Goose is player number: 6
Going around the circle more than once
The players are:
Nathan James Fred Sarah
The goose is: James

Enter the player to be the goose:
9
Goose is player number: 9
Going around the circle more than once
The players are:
Nathan James Fred Sarah Francois
The goose is: Sarah

*/

using System;

public class Kata
{
  public static string DuckDuckGoose(string[] players, int goose)
  {
  	Console.WriteLine("Goose is player number: {0}",goose);

  	if(goose>players.Length){
  		Console.WriteLine("Going around the circle more than once");
  	}

  	Console.WriteLine("The players are:");

  	for(int i=0;i<players.Length;i++)
  	{
  		Console.Write("{0} ",players[i]);
  	}

  	Console.WriteLine();

  	string Message = "The goose is: "+players[(goose-1)%players.Length];

  	return Message;

  }
}

class PlayGame 
{
	static void Main()
	{
		string[] PlayerNames = new string[] {"Nathan", "James", "Fred", "Sarah", "Francois"};

		Console.WriteLine("Enter the player to be the goose:");
		int UserChoice;
		int.TryParse(Console.ReadLine(),out UserChoice);

		Console.WriteLine(Kata.DuckDuckGoose (PlayerNames, UserChoice));
	}
}