/*(VehicleInherit)
http://www.blackwasp.co.uk/Inheritance.aspx

Create the Vehicle class. Provide a Speed property. Provide the Accelerate and Decelerate methods, which take a parameter of kmh by which to accelerate.

We can now create a class called "MotorVehicle" which represents motor vehicles such as cars, buses, etc, and which derives from the Vehicle class. 
Add properties to identify how many gallons of fuel are present in the vehicle (FuelRemaining) and how large the fuel tank is (FuelTankSize).
Create a method to call when the motor vehicle is refuelled, called Refuel, which completely fills the fuel tank.
The FuelRemaining property is read-only as it can only be changed via the Refuel method.

Create a class for bicycles named "Bicycle". Bicycles can also accelerate and decelerate and are also a type of Vehicle, so should inherit from the Vehicle class.

The basic Vehicle class will simply output a message describing the indication direction given (eg Turning left). This will be overridden in the MotorVehicle and Bicycle classes.
In the MotorVehicle class, the basic outputted message will be overridden to Flashing left/right indicator. 
For bicycles, the rider will raise their arm to indicate that they are turning so Bicycle class message should be: "Raising left/right arm"

Create some basic Vehicle variables but assign MotorVehicle or Bicycle objects to them

Sample Output:
MotorBike, of type Vehicle
Speed: 30 km/h
Turning Left!

Car, of type MotorVehicle
Refueled

Beetle, of type MotorVehicle
Flashing my left indicator

Bicycle, of type Vehicle
Raising my right arm
*/
using System;

namespace VehicleInherit{
	class MotorVehicle: Vehicle{
		private int _fuelRemaining;
	
		public int FuelRemaining {
			get{return _fuelRemaining;}
		}
		
		public int FuelTankSize {get;set;}
		
		internal void Refuel(){
			_fuelRemaining=FuelTankSize;
			Console.WriteLine("Refueled");
		}
			
		internal override void Indicate(bool TurningLeft){
			if(TurningLeft){
				Console.WriteLine("Flashing my left indicator");
			}
			else{
				Console.WriteLine("Flashing my right indicator");
			}
		}
	}
}