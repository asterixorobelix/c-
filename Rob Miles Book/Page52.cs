/*
Code Sample 12.
Page 52 of the Rob Miles c# programming pdf

Create a Method called ReadValue, which can prompt the user to enter a value between a max and a min, with a configurable message.
ReadValue should keep on prompting the user until valid input is entered.

Sample Output:
Enter a value  for the window width in meters, between 0 and 100
120
Enter a value  for the window width in meters, between 0 and 100
-11
Enter a value  for the window width in meters, between 0 and 100
t
Invalid input, please try again
Enter a value for the window width in meters, between 0 and 100
1.2
Enter a value  for the window width in meters, between 0 and 100
2
Valid input and within target range
*/

using System;

class Validate{
	//validates input of ints and checks entry is within configurable range. Returns a double. Can take a configurable message.
	static int ValidateInput(int min=0, int max=500, string prompt=""){
		bool IsValid=false;
		int EntryInt=0;
		
		while(!IsValid){
			Console.WriteLine("Enter a value {0}, between {1} and {2}",prompt,min,max);
			string Entry=Console.ReadLine();
			
			try{
				EntryInt = int.Parse(Entry);
				
				if(EntryInt>=min&&EntryInt<=max){
					IsValid=true;
				}
				
				else{
					Console.WriteLine("Input outside of range. Please try again");
				}
			}
			
			catch{
				Console.WriteLine("Invalid input, please try again");
			}
		}
		Console.WriteLine("Valid input and within target range");
		return EntryInt;
	}
	
	static void Main(){
		int Entry;
		string Message="for the window width in meters";
		
		Entry=ValidateInput(max:100,prompt:Message);
	}
}