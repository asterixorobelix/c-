/*
Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. 
Store the languages as a database (eg an object). 
It should default to English if the language is not in the database, or in the event of an invalid input.

The database:
{"english", "Welcome"},
{"czech", "Vitejte"},
{"danish", "Velkomst"},
{"dutch", "Welkom"},
{"estonian", "Tere tulemast"},
{"finnish", "Tervetuloa"},
{"flemish", "Welgekomen"},
{"french", "Bienvenue"},
{"german", "Willkommen"},
{"irish", "Failte"},
{"italian", "Benvenuto"},
{"latvian", "Gaidits"},
{"lithuanian", "Laukiamas"},
{"polish", "Witamy"},
{"spanish", "Bienvenido"},
{"swedish", "Valkommen"},
{"welsh", "Croeso"}

Sample Output:
Enter a language to select a greeting:
spanish
Bienvenido

Enter a language to select a greeting:
afrikaans
That language was not found in the database
Welcome
*/

using System;
using System.Collections.Generic;//for dictionary

public static class Kata
{
  public static string Greet(string language)
  {
  	/*
	Dictionary<TKey,TValue>
	TKey - The type of the keys in the dictionary.
	TValue - The type of the values in the dictionary.
	e.g:
	Dictionary<string, string>
	Dictionary<string, int>
	*/
    var greetings = new Dictionary<string, string>(){
      {"english", "Welcome"},
      {"czech", "Vitejte"},
      {"danish", "Velkomst"},
      {"dutch", "Welkom"},
      {"estonian", "Tere tulemast"},
      {"finnish", "Tervetuloa"},
      {"flemish", "Welgekomen"},
      {"french", "Bienvenue"},
      {"german", "Willkommen"},
      {"irish", "Failte"},
      {"italian", "Benvenuto"},
      {"latvian", "Gaidits"},
      {"lithuanian", "Laukiamas"},
      {"polish", "Witamy"},
      {"spanish", "Bienvenido"},
      {"swedish", "Valkommen"},
      {"welsh", "Croeso"}};

    try {
      return greetings[language];
    } 
    catch(KeyNotFoundException)
    {
    	Console.WriteLine("That language was not found in the database");
      return greetings["english"];
    }
  }
}

class GetGreeting{
	static void Main(){

		Console.WriteLine("Enter a language to select a greeting:");
		string UserSelection = Console.ReadLine();
		Console.WriteLine(Kata.Greet(UserSelection));
	}
}




