/*
Write function makeUpperCase.

Sample Output:
Enter a word to convert:
nathan
Converting to upper case
NATHAN

Enter a word to convert:
12
Converting to upper case
12

Enter a word to convert:
h@t
Converting to upper case
H@T
*/  
using System;

public class Kata
{
    public static string MakeUpperCase(string str)
    {
    	Console.WriteLine("You entered: {0}",str);
        return str.ToUpper();
    }
}

public class ConvertToUpperCase{

  	static void Main(){
  		Console.WriteLine("Enter a word to convert:");
  		string UserSelection=Console.ReadLine();

  		try{
  			Console.WriteLine("Converting to upper case");
  			Console.WriteLine(Kata.MakeUpperCase(UserSelection));
  		}

  		catch{
  			Console.WriteLine("Your entry was not a valid string");
  		}  		
  	}
}