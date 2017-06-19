/*Read an integer number from the user and return number of zeros in the tail.

Input:
1505560
Output:
1

Input:
1001
Output:
0
*/

using System;

class TailZeros{
	static void Main(){
		int Number;

		Console.WriteLine("Enter a number:");
		int.TryParse(Console.ReadLine(),out Number);

		int Zeroes =0;
		int i=Math.Abs(Number);//in case number is negative
		Console.WriteLine("Number: {0}",Number);

		while(i>9){
			if(i%10==0){
				Zeroes++;
				i=i/10;
			}

			else{
				break;
			}

		}		
		Console.WriteLine("The number of Tail zeroes is: {0}",Zeroes);
	}
}