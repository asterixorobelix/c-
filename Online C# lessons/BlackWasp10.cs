/*
http://www.blackwasp.co.uk/Interfaces.aspx

The first interface that we will create will be implemented by all animals that are prey to predators. To use the convention for interface naming, this interface will be called "IPrey".
The IPrey interface will define a property (FleeSpeed) to hold the fleeing speed of prey animals. This is an important value when an animal must run away from a predator.
The IPrey interface will include a method called when the animal attempts to escape from a predator. This method will be named "Flee" and will require no parameters. 
We will also create a second interface to represent predatory animals. This interface will define a property and a method. The property will hold the attack speed of all animals that implement the IPredator interface.
The interface's method, "Attack" will be called when the predator wants to attack another creature. This method will accept a single parameter containing the prey animal to be attacked. So that any prey animal may be attacked, the parameter will be of the IPrey type. 
create a class for cats. The class will implement the IPredator interface. To create the class, add a new class file to the project and name it "Cat".
create both a cat and a fish object before making the cat try to attack the fish. 
*/
