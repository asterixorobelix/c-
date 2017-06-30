/* 
 * http://www.blackwasp.co.uk/Interfaces.aspx
 *  In this article we will define interfaces and classes that represent predators and prey animals. Each animal class will implement at least one of the IPredator and IPrey interfaces.
 * The first interface that we will create will be implemented by all animals that are prey to predators. To use the convention for interface naming, this interface will be called "IPrey". To create the interface, add a new interface file to the project named "IPrey". 
 * The IPrey interface will define a property to hold the fleeing speed of prey animals. This is an important value when an animal must run away from a predator. 
 * The IPrey interface will include a method called when the animal attempts to escape from a predator. This method will be named "Flee" and will require no parameters.
 * We will also create a second interface to represent predatory animals. This interface will define a property and a method. The property will hold the attack speed of all animals that implement the IPredator interface.
   The interface's method, "Attack" will be called when the predator wants to attack another creature. This method will accept a single parameter containing the prey animal to be attacked. So that any prey animal may be attacked, the parameter will be of the IPrey type.
   Create a class for cats. The class will implement the IPredator interface. To create the class, add a new class file to the project and name it "Cat". 
   Create a Cat-specific "Purr" method
   Add a new class file named "Fish"
   Test the cat and fish classes using the Main method of the program. For this simple test, we will create both a cat and a fish object before making the cat try to attack the fish. 
   we have declared a class for fish and implemented the IPrey interface. Of course, fish can be predators too so we can sensibly implement the IPredator interface for this class. 
*/

using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPredator shark = new Fish();
            shark.AttackSpeed = 30;

            IPrey ray = new Fish();
            ray.FleeSpeed = 15;

            shark.Attack(ray);
            Console.ReadLine();
        }
    }
}
