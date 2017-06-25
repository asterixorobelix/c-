/*
Create a program which allows the user to enter a user-determined number of scores into an array, with a max of 5 scores. 
The program should check that the numbers are positive and less than 300. 
If not, do not add them to the array.
Display the valid entries after the user has entered their scores. Your solution should include input validation.

Sample Output:
Enter the number of scores to store:
3
Enter score:
t
Invalid Input
Enter score:
14578
Number outside of range
Enter score:
23
Enter score:
56
Enter score:
145
You entered:
23
56
145
*/

using System;

class ScoreStorage{

	static int Validator(string message,int min, int max){

		int UserEntry;
		
		Console.WriteLine(message);

		try{

			UserEntry=int.Parse(Console.ReadLine());

			if(UserEntry>=min && UserEntry<=max){
				return UserEntry;
			}

			else{
				Console.WriteLine("Number outside of range");
			}
		}

		catch{
			Console.WriteLine("Invalid Input");
		}
		return UserEntry=-1;		
	}

	static void Main(){

		string Message = "Enter the number of scores to store:";

		int Scores=-1;

		do{
			Scores=Validator(Message,0,5);
		} while(Scores<0);
		
		int i=0;
		int UserScore;

		Message="Enter score:";

		int[] ScoresDatabase = new int[Scores];

		while (i<Scores){
			UserScore=Validator(Message,0,300);
			if(UserScore>0){
				ScoresDatabase[i]=UserScore;
				i++;
			}
		}
		
		Console.WriteLine("\nYou entered:");
		foreach (int j in ScoresDatabase){
			Console.WriteLine(j);
		}
	}
}