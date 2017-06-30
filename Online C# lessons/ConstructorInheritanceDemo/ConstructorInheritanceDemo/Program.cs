/*
 * http://www.blackwasp.co.uk/ConstructorInheritance.aspx
 * Create a class called Program which instantiates a MySubclass object. 
 * MyBaseClass is a class with a single constructor which outputs a message to the console. 
 * MySubclass inherits from MyBaseClass and also outputs to the console when constructed.
 * Add a destructor to the MyBaseClass and the MySubClass
 * Add a new constructor to "MyBaseClass". This constructor will accept a single integer parameter, which will be outputted to the console.
 * Add a constructor to "MySubclass" that calls the new base class constructor when an object is instantiated
 * 
 * OUTPUT
    MyBaseClass created with value 10.
    MySubclass created with value 10.
    MySubclass destructor called.
    MyBaseClass destructor called.
 * */
namespace ConstructorInheritanceDemo
{
    class Program
    {
        static void Main()
        {
            MySubclass test = new MySubclass(10);
        }
    }
}