/*
The objective of 'Duck, duck, goose' is to walk in a circle, tapping on each player's head until one is finally chosen. 

Task: Given an array of Player objects and an index (1-based), return the name of the chosen Player. 

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
The players are:
Nathan James Fred Sarah
The goose is: James
*/

using System;

public class Kata
{
  public static string DuckDuckGoose(string[] players, int goose)
  {
  	Console.WriteLine("Goose is player number: {0}",goose);

  	Console.WriteLine("The players are:");

  	for(int i=0;i<players.Length;i++){
  		Console.Write("{0} ",players[i]);
  	}

  	Console.WriteLine();

  	int PlayerNumber = players.Length;

  	if(goose>PlayerNumber){
  		goose=goose-PlayerNumber;
  	}

  	string Message = "The goose is: "+players[goose-1];

  	return Message;
  }

}
public class Player 
{
  public string Name {get;set;}
  
  public Player (string name) 
  {
  	this.Name = name;
  }
}

class PlayGame 
{
	static void Main()
	{
		string[] PlayerNames = new string[5] {"Nathan", "James", "Fred", "Sarah", "Francois"};

		Console.WriteLine("Enter the player to be the goose:");
		int UserChoice;
		int.TryParse(Console.ReadLine(),out UserChoice);

		Console.WriteLine(Kata.DuckDuckGoose (PlayerNames, UserChoice));
	}
}