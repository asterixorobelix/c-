/*Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
For numbers which are multiples of both three and five print "FizzBuzz".
*/

using System;

class FizzBuzz{
	static void Main(){
		int i=1;

		while(i<=100){
			
			if(i%3==0 && i%5==0){
				Console.WriteLine("FizzBuzz");
			}

			else if(i%5==0){
				Console.WriteLine("Buzz");
			}

			else if(i%3==0){
				Console.WriteLine("Fizz");
			}


			else{
				Console.WriteLine(i);
			}

			i++;
		}
	}
}