/*
Write a program which reads in the width and height of a window and then print out the amount of wood and glass required to make a window which will fit in a hole of that size.

Sample Output:
*/

using System;

class GlazerCalc
{
    static void Main()
    {
        Console.WriteLine("This program asks you for the width and height of a window and calculates the area of glass required to fill the hole");
        double width, height, woodLength, glassArea;
        string widthString, heightString;
        
        Console.WriteLine("Enter width:");

        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        
        Console.WriteLine("Enter height:");

        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;

        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
    }
}
