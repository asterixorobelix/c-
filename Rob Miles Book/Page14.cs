/*
Code Sample 1.
Page 14 of the Rob Miles c# programming pdf

Write a program which reads in the width and height (as doubles) of a  hole in the wall for a window.
The program should then print out the amount of wood required for the frame (in metres) and glass required to double glaze a window of that size.

Sample Output:
This program asks you for the width and height of a window and calculates the area of glass required to fill the hole
Enter width in metres:
2.3
Enter height in metres:
1.1
The length of the wood for the frame is: 6.8 metres
The area of glass required for double glazing is 5.06 square metres
*/

using System;//using the System namespace

class GlazerCalc
{
    static void Main()
    {
        Console.WriteLine("This program asks you for the width and height of a window and calculates the area of glass required to fill the hole");
        double width, height, woodLength, glassArea;
        string widthString, heightString;
        
        Console.WriteLine("Enter width in metres:");

        widthString = Console.ReadLine();
        width=double.Parse(widthString);//If the string is not in a valid format, Parse throws an exception whereas TryParse returns false.
        
        Console.WriteLine("Enter height in metres:");

        heightString = Console.ReadLine();
        height=double.Parse(heightString);

        woodLength = 2 * (width + height);//width+height

        glassArea = 2 * (width * height);//width*height. Doubling the area because its double glazing.

        Console.WriteLine("The length of the wood for the frame is: {0} metres ", woodLength);
        Console.WriteLine("The area of glass required for double glazing is {0} square metres",glassArea);
		
    }
}
