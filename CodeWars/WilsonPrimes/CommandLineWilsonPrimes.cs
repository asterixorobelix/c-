/*Wilson primes satisfy the following condition. Let P represent a prime number.

Then ((P-1)! + 1) / (P * P) should give a whole number.

Your task is to create a function that returns true if the given number is a Wilson prime

*/

using System;

public class WilsonPrimes {
    
    static void Main(){
        double number;
        
        Console.WriteLine(("Enter number to test for WilsonPrimes"));
        number=double.Parse(Console.ReadLine());
        
               
        Console.WriteLine(("You entered: {0}",number));
        height=double.Parse(Console.ReadLine());
        
        if(getWilsonPrimeResult(number)){
			Console.WriteLine("This is a Wilson Prime");
		}
		
		else{
			Console.WriteLine("This is not a Wilson Prime");
		}
        
    }
    
  public static double getWilsonPrimeResult(double num) {
    double factorial =0;
	
	for (int i = num;i>1;i--){
		factorial*=(i-1);
	}
	result =(factorial+1)/(num*num);
	
	if(result%0){
		return true;
	}
	
	else{
		return false;
	}
	
  }
}