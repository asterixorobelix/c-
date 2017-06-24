/*
Write a function called repeatStr which repeats the given string string exactly n times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"

SampleOutput:
Enter a word:
Hello
Enter the number of times to repeat the word:
4
HelloHelloHelloHello
*/

using System;

namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
    	string Repeated = "";

    	for(int i=1;i<=n;i++){
    		Repeated=Repeated+s;
    	}
    	return Repeated;
    }

    static void Main(){
    	Console.WriteLine("Enter a word:");

    	string UserWord = Console.ReadLine();

    	Console.WriteLine("Enter the number of times to repeat the word:");

    	int Repeats;

    	try{
    		Repeats=int.Parse(Console.ReadLine());
    		Console.WriteLine(repeatStr(Repeats,UserWord));
    	}

    	catch{
    		Console.WriteLine("Invalid entry");
    	}
    }
  }
}