/*
Philip's just turned four and he wants to know how old he will be in various years in the future such as 2090 or 3044. 
His parents can't keep up calculating this so they've begged you to help them out by writing a programme that can answer Philip's endless questions.
Your task is to write a function which takes two parameters: the year of birth and the year to count years in relation to. 
Since Philip is getting more courious every day he may soon want to know how many years it was until he would be born, so your function needs to work with both dates in the future and in the past.
Provide output in this format: For dates in the future: "You are ... year(s) old." For dates in the past: "You will be born in ... year(s)." 
If the year of birth equals the year requested return: "You were born this very year!"
"..." are to be replaced by the number, followed and proceeded by a single space.
Make sure that you need to account for both "year" and "years", depending on the result.

Sample Output:
Enter your year of birth:
1986
Enter year to calculate to:
2017
You are 31 years old

Enter your year of birth:
1986
Enter year to calculate to:
1922
You will be born in 64 years

Enter your year of birth:
1986
Enter year to calculate to:
1987
You are 1 years old

Enter your year of birth:
1956
Enter year to calculate to:
a
That input is not recognized
*/

using System;

public static class AgeDiff 
{
	public static string CalculateAge(int birth, int yearTo)
	{

	  	int yearDifference = yearTo-birth;
	  	string Message;

	    if(yearDifference>0){//future

	    	if(birth+yearTo==1){
	    		Message="You are 1 year old";
	    	}

	    	else{
	    		Message= "You are "+(yearTo-birth)+" years old";
	    	}    	
	    }

	    else if(yearDifference<0){//past

	    	if(yearTo-birth==1){
	    		Message="You will be born in 1 year";
	    	}

	    	else{
	    		Message="You will be born in "+(birth-yearTo)+" years";
	    	}
	    }

	    else{
	    	Message="You were born this very year!";
	    }

	    return Message;
	}
}

public static class CalculateAgeDiff{
	public static void Main(){
		int BirthYear, YearToCalculate;

		Console.WriteLine("Enter your year of birth:");
		try{
			BirthYear=int.Parse(Console.ReadLine());

			Console.WriteLine("Enter year to calculate to:");

			try{
				YearToCalculate= int.Parse(Console.ReadLine());
				Console.WriteLine(AgeDiff.CalculateAge(BirthYear,YearToCalculate));
			}

			catch{
				Console.WriteLine("That input is not recognized");
			}
		}
		
		catch{
			Console.WriteLine("That input is not recognized");
		}		
	}
}