/*Write a program which takes in a measurement in feet and returns the answer in inches.
1 foot is 12 inches.
Use a function called FeetToInches in order to do the conversion.

Sample Output:
Enter a measurement in feet to convert:
12.5

12.5 feet is 150 inches
*/

using System;

class MeasurementConverter{
    static void Main(){
        Console.WriteLine("Enter a measurement in feet to convert:\n");
        
        double feet= Convert.ToDouble(Console.ReadLine());//ReadLine returns a string
        
        FeetToInches(feet);
    }
    
    static void FeetToInches(double a){//Why does public void FeetToInches not work?
        double inches = a*12;
        
        Console.WriteLine("\n{0} feet is {1} inches",a,inches);
    }
}
