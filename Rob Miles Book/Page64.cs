/*
Page 64 of Rob Miles pdf. Code Sample 16.

Create a program which allows the user to enter 5 scores into an array. The program should check that the numbers are positive and less than 300. 
If not, do not add them to the array.
Display the valid entries after the user has entered 5 scores.

Sample Output:
You will be able to enter 5 scores
Score : -1
Score : 11
Score : 2
Score : 400
Score : 34
Score : 2
Score : 11
You entered:
Score: 11
Score: 2
Score: 34
Score: 2
Score: 11
*/

using System;

class ArrayDemo
{
    static string readString(string prompt)
    {
        string result;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
        } while (result == "");
        return result;
    }

    static int readInt(string prompt, int low, int high)
    {
        int result;

        do
        {
            string intString = readString(prompt);
            result = int.Parse(intString);
        } while ((result < low) || (result > high));

        return result;
    }

    public static void Main()
    {
        const int SCORE_SIZE = 5;
        int[] scores = new int[SCORE_SIZE];

        Console.WriteLine("You will be able to enter {0} scores",SCORE_SIZE);
        for (int i = 0; i < SCORE_SIZE; i = i + 1)
        {
            scores[i] = readInt("Score : ", 0, 300);
        }

        // Now print the scores out
        Console.WriteLine("You entered:");
        for (int i = 0; i < SCORE_SIZE; i = i + 1)
        {
            Console.WriteLine( "Score: " + scores[i] );
        }
    }
}
