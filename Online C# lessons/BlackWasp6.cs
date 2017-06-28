/* 
http://www.blackwasp.co.uk/CSharpStaticBehaviour.aspx

create a new class named 'MassCalculator', which multiplies density*volume. 
This class provides a method which accepts the density and the volume of an item and calculates its mass. 
The class will also maintain a property which counts the number of times that the calculation has been performed. 


Sample Output:
Mass1: 5000
Mass2: 9000
Calls: 2
*/


using System;


namespace CSharpStaticBehaviour
{
    class MassCalculator
    {
        private static int _callCount; //private variables may not be accessed by static methods, and this also applies in the case of static properties. Instead, we must create a static private variable if the property value is to be held rather than calculated.
              
        static void Main()
        {
            int density = 50;
            int volume = 100;
            int volume2 = 180;

            int mass1 = MassCalculator.CalculateMass(density, volume);
            int mass2 = MassCalculator.CalculateMass(density, volume2);
            int calls = MassCalculator.CallCount;

            Console.WriteLine("Mass1: {0}", mass1);         // Outputs "Mass1: 5000"
            Console.WriteLine("Mass2: {0}", mass2);         // Outputs "Mass2: 9000"
            Console.WriteLine("Calls: {0}", calls);         // Outputs "Calls: 2"
        }
		
        public static int CalculateMass(int density, int volume)
        {
            _callCount++;
            return density * volume;
        }

        public static int CallCount //adding a static property to a class requires only that the declaration includes the 'static' keyword to modify the property's behaviour
        {
            get// Read-only because only a get is provided
            {
                return _callCount;
            }
        }

        static MassCalculator()//Default Constructor
        {
            _callCount = 0;
        }
    }
}
