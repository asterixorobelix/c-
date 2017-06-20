/*
Write a program which can hold ten values, entered by the user, from 1 to 100. Find the largest value in the array, and display that value.

Array:
12
32
43
45
456
65
76
87
98
908
The largest value is 908
*/
using System;

class LargestValue{
	static void Main(){
		int Entry;

		int[] UserEntries= new int[10];

		Console.WriteLine("Enter ten values, between 1 and 100:");

		for (int i=0;i<10;i++){
			Console.WriteLine("Enter number:");
			int.TryParse(Console.ReadLine(),out Entry);

			if(Entry<100 && Entry>1){
				UserEntries[i]=Entry;
			}

			else{
				Console.WriteLine("Please enter a number between 1 and 100");
			}
		}

		Console.WriteLine("You entered:");
		for(int j=0;j<10;j++){
			Console.WriteLine(UserEntries[j]);
		}

		FindLargestValue(UserEntries);
	}

	static void FindLargestValue(int[] UserArray){
		int LargestValue =-10000;

		for(int i=0;i<10;i++){
			if(UserArray[i]>LargestValue){
				LargestValue=UserArray[i];
			}
		}

		Console.WriteLine("The LargestValue is {0}",LargestValue);
	}
}
