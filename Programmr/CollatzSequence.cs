/*
Take any natural number n.

If n is even, divide it by 2 to get n / 2.
If n is odd, multiply it by 3 and add 1 to get 3n + 1.
Repeat the process indefinitely.
In 1937, Lothar Collatz proposed that no matter what number you begin with, the sequence eventually reaches 1. This is widely believed to be true, but has never been formally proved.

Write a program which inputs a number from the user, and then displays the Collatz Sequence starting from that number. 
Stop when you reach 1. It should also count the steps that it takes to get to 1.

Starting number:
5
5 16 8 4 2 1
Terminated after:5 steps
*/

using System;

class CollatzSequence{
	static void Main(){
		int UserEntry;

		Console.WriteLine("Enter your starting number:");
		int.TryParse(Console.ReadLine(),out UserEntry);

		if(UserEntry>0){

			CalculateCollatz(UserEntry);
		}

		else{
			Console.WriteLine("Only positive numbers");
		}		
	}


	static void CalculateCollatz(int number){
		int Count=0;

		while (number!=1){

			if (number%2==0){
				number =number/2;
			}
			else{
				number=number*3+1;
			}
			Console.WriteLine(number);
			Count++;
		}

		Console.WriteLine("Terminated after: {0} steps",Count);		
	}
}

