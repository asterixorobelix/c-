/*
Create a regular expression to validate full names such as Jane Chen, Ron Terencio, or Raj Bains. 
Assume that each first name and last name must begin with a capital letter and that all other characters in the name must be lowercase letters. 
Each full name only has a first name and a last name. 
There are no hyphens. First and last names are separated with one space.

Sample Output:
Enter your name:
Nathan Stasin
That is a name

Enter your name:
bob tabor
That is not a name

*/
using System;
using System.Text.RegularExpressions;

namespace Example6point4{
	class Program{
		static void Main(){
			//@ is a verbatim string literal
			const string PATTERN= @"[A-Z][a-z]+\s+[A-Z][a-z]+";
			//+ is one or more.
			
			Regex reg = new Regex(PATTERN);
			
			Console.WriteLine("Enter your name: ");
			
			string Name = Console.ReadLine();
			
			if(reg.IsMatch(Name)){
				Console.WriteLine("That is a name");
			}
			else{
				Console.WriteLine("That is not a name");
			}
			
		}
	}
}