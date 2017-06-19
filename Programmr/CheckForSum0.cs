/*
We are given 5 integer numbers. Write a program which checks if the sum of them is 0. and return true if any subset founded has sum=0 else false

Input:
1 2 3 4 5
Expected Output :
False

Input :
1 2 3 -2 -1
Expected Output :
True

Input:
1 2 3 -4 5
Expected ouput:
False
*/

using System;

class CheckForSum{
	static void Main(){
		int Sum;
		int[] Entries =new int[5];//Declaring and initializing an array
		bool EqualsZero = false;

		for(int i=0;i<5;i++){
			Console.WriteLine("Enter number:");
			int.TryParse(Console.ReadLine(),out Entries[i]);
		}


		for(int i=0;i<5;i++){
			Sum=0;
			Sum+=Entries[i];

			if(Sum==0){
				EqualsZero=true;
				break;
			}
			
		}

		Console.WriteLine(EqualsZero);

	}
}