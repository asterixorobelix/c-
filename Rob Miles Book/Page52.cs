/*
Code Sample 12.
Page 52 of the Rob Miles c# programming pdf

Create a Method called ReadValue, which can prompt the user to enter a value between a max and a min, with a configurable message.

Sample Output:
Enter width of window:  between 0.5 an
4
Width: 4
Enter your age:  between 0 and 70
34
Age: 34
*/

using System;

class UsefulMethod
{
    // prompt for the user 
    // lowest allowed value
    // highest allowed value
    static double readValue(string prompt, double low, double high)
    {
        double result = 0;
        do
        {
            Console.WriteLine("{0} between {1} and {2}",prompt,low,high);
            string resultString = Console.ReadLine();
            result = double.Parse(resultString);
        } while ((result < low) || (result > high));

        return result;
    }

    const double MAX_WIDTH = 5.0;
    const double MIN_WIDTH = 0.5;

    public static void Main()
    {
        double windowWidth = readValue("Enter width of window: ", MIN_WIDTH, MAX_WIDTH);

        Console.WriteLine("Width: " + windowWidth);

        double age = readValue("Enter your age: ", 0, 70);

        Console.WriteLine("Age: " + age);
    }
}
