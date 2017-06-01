using System;

namespace HelloWorldApplication //Namespace declaration
{
   class HelloWorld //A class declaration: The HelloWorldApplication namespace contains the class HelloWorld.
   {
      static void Main(string[] args)//the HelloWorld class has only one method, Main. Main is the entry point for all C# programs. The Main method states what the class does when executed.
      {
         /* my first program in C# */
         Console.WriteLine("Hello World");//specifies behaviour with the statement Console.WriteLine("Hello World");
         //WriteLine is a method of the Console class defined in the System namespace. 
         Console.ReadKey();  //This makes the program wait for a key press and it prevents the screen from running and closing quickly when the program is launched.
         //This is unnecessary if the code is being run from the console.
      }
   }
}