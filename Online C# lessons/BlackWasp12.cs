/*
http://www.blackwasp.co.uk/Inheritance.aspx
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

        }
    }
}