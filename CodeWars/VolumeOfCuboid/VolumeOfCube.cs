/*Bob needs a fast way to calculate the volume of a cuboid with three values: length, width and the height of the cuboid. 
Write a function to help Bob with this calculation.

Sample Output:
Enter length of cube:
12.3
Enter width of cube:
34
Enter height of cube:
56.2
The volume is: 23502.84
*/
using System;

public class Kata {
    
    static void Main(){
        double length, height, width;
        
        Console.WriteLine(("Enter length of cube:"));
        length=double.Parse(Console.ReadLine());
        
        Console.WriteLine(("Enter width of cube:"));
        width=double.Parse(Console.ReadLine());
        
        Console.WriteLine(("Enter height of cube:"));
        height=double.Parse(Console.ReadLine());
        
        getVolumeOfCubiod(length, width, height);
        
    }
    
  public static double getVolumeOfCubiod(double length, double width, double height) {
    
    double volume = length*height*width;
    Console.WriteLine("The volume is: {0:0.00}",volume);
    return volume;
  }
}