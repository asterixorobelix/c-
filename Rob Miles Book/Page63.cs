/*
Code Sample 16.
Page 63 of the Rob Miles c# programming pdf

Given a set of player scores from a game, list of those scores in ascending order.
No player can score less than 0 or more than 1000 runs in a game.
*/

using System; 

class CricketScores {

	static string readString(string prompt) 
	{ 
		string result; 
		do { 
			Console.Write(prompt); 
			result = Console.ReadLine(); 
		} while (result == ""); 

		return result; 
	}

	static int readInt(string prompt, int low, int high) 
	{ 
		int result; 

		do { string intString = readString(prompt); 
			result = int.Parse(intString); 
		} while ((result < low) || (result > high)); 

		return result; 
	}

	public static void Main () 
	{ 
		int [] scores = new int [11] ;

		for ( int i=0; i<11; i=i+1) 
		{ 
			scores [i] = readInt ( "Score : ", 0,1000); 
		} 
	}
}