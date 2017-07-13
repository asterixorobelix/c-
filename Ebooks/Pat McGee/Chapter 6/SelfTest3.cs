/*
Write a regular expression which permits the entry of a valid @retrofitness.com e-mail address where the
address prefix may contain alphabetical, underscore, hyphen, and dot characters. 
Note also that the first character in the e-mail address must be an alphabetical character.

Sample Output:
Enter your retrofitness.com email address:
nathanstasin@gmail.com
That is not a valid email

Enter your retrofitness.com email address:
nathanstasin@retrofitness.com
That is a valid email
*/

using System;
using System.Text.RegularExpressions;

namespace SelfTest3{
	class Program{
		static void Main(){
			//$ ends with pattern
			//* 0 or more
			const string PATTERN= @"^[A-Za-z]+_*-*.*(@retrofitness.com)$";
			//+ is one or more.
			
			Regex reg = new Regex(PATTERN);
			
			Console.WriteLine("Enter your retrofitness.com email address: ");
			
			string Name = Console.ReadLine();
			
			if(reg.IsMatch(Name)){
				Console.WriteLine("That is a valid email");
			}
			else{
				Console.WriteLine("That is not a valid email");
			}
		}
	}
}