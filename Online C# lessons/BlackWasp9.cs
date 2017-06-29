/*
http://www.blackwasp.co.uk/Namespaces.aspx
This code creates a new namespace named "FirstNamespace" and defines a "Test" class, containing a single method that outputs a string to the console.
Create a second namespace which also includes a class named "Test", containing a single method that outputs a string to the console.
Extend the "FirstNamespace" namespace, adding a second class called ShortTest, which also outputs a string to the console.

Sample Output:
This is the first namespace!
This is the second namespace!
First namespace
*/
using System;

namespace FirstNamespace
{
    class Test
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is the first namespace!");
        }
    }
}

namespace SecondNamespace
{
    class Test//This does not cause a naming conflict because the two classes are logically separated by the namespaces. This means that the program will compile without error.
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is the second namespace!");
        }
    }
}

namespace FirstNamespace //Namespace declarations are additive. This means that the same namespace definition can be included in your code in multiple locations.
{
    class ShortTest
    {
        public void ShowShortMessage()
        {
            Console.WriteLine("First namespace!");
        }
    }
}

class Program{
	static void Main(){
		FirstNamespace.Test t = new FirstNamespace.Test();
		t.ShowMessage();
		
		SecondNamespace.Test t1 = new SecondNamespace.Test();
		t1.ShowMessage();
		
		FirstNamespace.ShortTest t2= new FirstNamespace.ShortTest();
		t2.ShowShortMessage();
	}
}