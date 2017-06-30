/*
http://www.blackwasp.co.uk/Inheritance.aspx

Create the Vehicle class. We will then create subclasses of Vehicle with more specialised functionality.
Provide a Speed property and the Accelerate and Decelerate methods in the vehicles class.
We can now create a class to represent motor vehicles such as cars, buses, etc. Since a motor vehicle is a specialised type of vehicle, we can derive the class from Vehicle. 
So, create new class and name it "MotorVehicle".
Add properties to identify how many gallons of fuel are present in the vehicle and how large the fuel tank is. We can also create a method to call when the motor vehicle is refuelled.
The FuelRemaining property is read-only as it can only be changed via the Refuel method, which returns the number of gallons of fuel added to completely fill the tank.

Create another class for bicycles named "Bicycle". Bicycles can also accelerate and decelerate so modify the class so that it also inherits its functionality from the Vehicle class.
To give the Bicycle class additional functionality, let's add a method which rings the bell. In order to indicate that the rider has used the bell we will simply output a string to the console.

The basic Vehicle class will simply output a message describing the indication direction given (eg Turning left). This will be overridden in the MotorVehicle and Bicycle classes.
In the MotorVehicle class, the basic outputted message will be overridden to Flashing left/right indicator. 
For bicycles, the rider will raise their arm to indicate that they are turning so Bicycle class message should be: "Raising left/right arm"

Add a property to the MotorVehicle class which calculates the fuel efficiency of the motor vehicle in miles per gallon, with the calculation based upon the current speed of the vehicle.

Create some basic Vehicle variables but assign MotorVehicle or Bicycle objects to them

Sample Output:
Speed: 0mph
Speed: 25mph
Speed: 10mph
Fuel: 0g
Fuel: 11g
Ring!
Flashing left indicator
Turning left
Raising left arm
Flashing left indicator
Turning left
Raising left arm
*/

using System;

namespace InheritanceDemo
{
	public class Vehicle
	{
		protected int _speed;     // Miles per hour. A protected member is accessible within its class and by derived class instances.

		public int Speed
		{
			get
			{
				return _speed;
			}
		}

		public void Accelerate(int mph)
		{
			_speed += mph;
		}

		public void Decelerate(int mph)
		{
			_speed -= mph;
		}

		public virtual void Indicate(bool turningLeft) //The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. 
		//By default, methods are non-virtual. You cannot override a non-virtual method.
		{
			if (turningLeft)
				Console.WriteLine("Turning left");
			else
				Console.WriteLine("Turning right");
		}
	}
	
	class MotorVehicle : Vehicle
    {
        private float _fuelRemaining;
        private float _tankSize;


        public float FuelRemaining
        {
            get
            {
                return _fuelRemaining;
            }
        }

        public int Mpg
        {
            get
            {
                if (_speed == 0)
                    return 0;
                else if (_speed < 20)
                    return 50;
                else if (_speed < 50)
                    return 40;
                else
                    return 35;
            }
        }

        public float TankSize
        {
            get
            {
                return _tankSize;
            }
            set
            {
                _tankSize = value;
            }
        }

        public float Refuel()
        {
            float fuelRequired = _tankSize - _fuelRemaining;
            _fuelRemaining = _tankSize;
            return fuelRequired;
        }

        public override void Indicate(bool turningLeft) //The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        {
            if (turningLeft)
                Console.WriteLine("Flashing left indicator");
            else
                Console.WriteLine("Flashing right indicator");
        }
    }
	
	class Bicycle : Vehicle
    {
        public void RingBell()
        {
            Console.WriteLine("Ring!");
        }


        public override void Indicate(bool turningLeft)
        {
            base.Indicate(turningLeft);

            if (turningLeft)
                Console.WriteLine("Raising left arm");
            else
                Console.WriteLine("Raising right arm");
        }

    }
		
	class Program
		{
        static void Main(string[] args)
        {
            MotorVehicle car = new MotorVehicle();
            Console.WriteLine("Speed: {0}mph", car.Speed);    // Outputs "Speed 0mph"
            car.Accelerate(25);
            Console.WriteLine("Speed: {0}mph", car.Speed);    // Outputs "Speed 25mph"
            car.Decelerate(15);
            Console.WriteLine("Speed: {0}mph", car.Speed);    // Outputs "Speed 10mph"
						
			car.TankSize = 11;
			Console.WriteLine("Fuel: {0}g", car.FuelRemaining); // Outputs "0g"
			car.Refuel();
			Console.WriteLine("Fuel: {0}g", car.FuelRemaining); // Outputs "11g"
			 
			Bicycle bike = new Bicycle();
			bike.RingBell();  // Outputs "Ring!"
			car.Indicate(true); // Outputs "Flashing left indicator"
 			bike.Indicate(true);  //Outputs Turning left 
									//Outputs Raising left arm
									
			Vehicle Beetle = new MotorVehicle();
			Vehicle Unicycle = new Bicycle();
			Beetle.Indicate(true);
			Unicycle.Indicate(true);

        }
    }
}