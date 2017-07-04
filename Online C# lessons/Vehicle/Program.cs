/*(Vehicle)
http://www.blackwasp.co.uk/CSharpSimpleClass_2.aspx
Create a class called Vehicle. Add new method to the vehicle class for pressing a vehicle's horn.
Create a new vehicle object and run its PressHorn method to see the results. 

Sample Output:
beep beeep Hoot hoot
*/
using BlackWasp;

namespace VehicleApp{
	
	class Program{
		static void Main(){
			Vehicle Bus = new Vehicle("Beep-Beep-Beeeep!");
			Bus.PressHorn();
		}		
	}
}