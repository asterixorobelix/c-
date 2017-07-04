/*(Car)
http://csharp.net-tutorials.com/classes/introduction/
Define a new class, called Car, which holds a single variable, called color. Use a color property to access the color variable.
Create a constructor for your Car class, which takes a parameter which allows us to initialize Car objects with a color. 
Also create the Describe() method, which prints out the colour of a Car.

Create another class called Program which creates several Car objects and assigns different colours to them.

Compilation:
C:\Users\nathan.stasin\Desktop\cSharp\Online C# lessons\Car>csc *.cs

Execution:
Program.cs

Sample Output:
This car is Red
This car is Green
*/

namespace cSharpTut
{
    class Program
    {
        static void Main()
        {

            Car Beetle = new Car("Red");
            Beetle.Describe();

            Car Porsche = new Car("Pink");
            Porsche.Describe();
            
        }
    }
}
