/*Given the string, check if it is a palindrome. Don't worry about error handling or validating input.

Examples
For inputString = "aabaa", the output should be
checkPalindrome(inputString) = true;

Input/Output
[input] string inputString: A non-empty string consisting of lowercase characters.
[output] boolean: true if inputString is a palindrome, false otherwise.

Guaranteed constraints: 1 ≤ inputString.length ≤ 105.

Sample Output:
Enter a name to test for palindrome:
hello
Is hello a palindrome?
False

Enter a name to test for palindrome:
bob
Is bob a palindrome?
True

Tests
input: abac, result: false
input: a, result: true 
*/

using System;

class CheckPalindrome{
	
	static bool checkPalindrome(string inputString) {
		bool IsSame=false;
		
		for(int i =0; i<inputString.Length;i++){
			
			if(inputString[i]==inputString[inputString.Length-1-i]){
				IsSame=true;
			}
			else{
				return false;
			}
		}
		return IsSame;
	}
	
	static void Main(){
		Console.WriteLine("Enter a name to test for palindrome:");
		
		string UserString=Console.ReadLine();
		bool Palindrome = checkPalindrome(UserString);
		Console.WriteLine("Is {0} a palindrome? {1}",UserString, Palindrome);			
	}
}