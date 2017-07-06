/*(IPredatorIPrey)
http://www.blackwasp.co.uk/Interfaces.aspx
In this article we will define interfaces and classes which represent predators and prey animals. Each animal class will implement at least one of the IPredator and IPrey interfaces.
Define an interface called IAnimal, which will have a property which holds the name of the type of animal.

Create an interface called "IPrey", which will be implemented by all prey animals. 
The IPrey interface will define a property to hold the fleeing speed of prey animals, of type double. This is an important value when an animal must run away from a predator. 
The IPrey interface will include a method called when the animal attempts to escape from a predator. This method will be named "Flee" and will require no parameters and return no value.

Create a second interface which represents predatory animals, called IPredator. This interface will define a property and a method. The property will hold the attack speed (double) of all animals which implement the IPredator interface.
The interface's method, "Attack" will be called when the predator wants to attack another creature. This method will accept a single parameter containing the prey animal to be attacked and returns no value. 
So that any prey animal may be attacked, the parameter will be of the IPrey type.

Create a class for Cats. The class will implement the IPredator interface. So, it should specify how the properties Name and AttackSpeed will work. It should also specify how the Attack method will work.
For the Attack method, if the AttackSpeed of the Predator animal is greater than the FleeSpeed of the Prey animal, write to the console that the animal was caught.

Add a new class file named "Fish". Of course, fish can be predators too; so we can sensibly implement the IPredator interface for this class. It also needs to implement the PreyFleeSpeed and the Flee method.
The Flee method writes to the console that the fish is fleeing.
Create both a cat and a fish object before making the cat try to attack the fish.

Sample Output:
I am fleeing!
The prey has been caught! 
*/
namespace IPredatorIPrey{
	
	interface IPredator: IAnimal{
		
		double AttackSpeed {get;set;}
		void Attack (IPrey prey);
	}
}