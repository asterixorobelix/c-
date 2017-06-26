/*
Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.

Examples
For year = 1905, the output should be
centuryFromYear(year) = 20;
For year = 1700, the output should be
centuryFromYear(year) = 17.

input: A positive integer, designating the year where: 1 ≤ year ≤ 2005.
output: An integer representing the number of the century the year is in.

include a way to test your code with random years.

Sample Output:
Enter a year to calculate the century from:
1905
Year: 1905
The century of year 1905 is 20

Enter a year to calculate the century from:
1700
Year: 1700
The century of year 1700 is 17

Enter a year to calculate the century from:
y
Invalid input, generating random year..
Year: 491
The century of year 491 is 5
*/

using System;

class CenturyFromYear{
	
	static int CalculateCentury(int year){
		int Century;
		Console.WriteLine("Year: "+year);
		
		if(year%100==0){
			Century=year/100;
		}
		
		else{
			Century=(year/100)+1;
		}
		return Century;
	}
	
	static void Main(){
		int RandomYear;
		
		Console.WriteLine("Enter a year to calculate the century from:");
		
		try{
			RandomYear=int.Parse(Console.ReadLine());
		}
		
		catch{
			Console.WriteLine("Invalid input, generating random year..");
			Random RandomYr = new Random();
			RandomYear = RandomYr.Next(1,2005);
		}
		
		Console.WriteLine("The century of year {0} is {1}",RandomYear,CalculateCentury(RandomYear));
	}
}

//OR
/*
int centuryFromYear(int year) {
    return (year%100 == 0) ? year/100 : year/100+1;
}
*/