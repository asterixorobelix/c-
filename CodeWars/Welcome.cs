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
*/

public static class Kata
{
    public static void Main(){
    	Language English = new Language (Greeting = "Welcome");
    	Console.WriteLine(English.Greeting);
    }

}

public static class Language{

	public string Greeting{get;set;}
}




