/*
Page 58 of Rob Miles c# book.
Code Sample 13.

Make a library which contain a method for reading a string and a method for reading an int and checking that it is between a min and max value.
*/

using System;
using NathanLibrary;

namespace NathanLibrary{
    class MethodLibraries
    {
        public static string ReadString(string prompt)//defaults to private if public not specified
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");

            return result;
        }

        public static int ReadInt(string prompt, int low, int high)//defaults to private if public not specified
        {
            int result;

            do
            {
                string intString = ReadString(prompt);
                result = int.Parse(intString);
            } while ((result < low) || (result > high));

            return result;
        }
    }
}

class NameAge{  

    public static void Main()
    {
        string name;
        name = MethodLibraries.ReadString("Enter your name : ");
        Console.WriteLine("Name: " + name);

        int age;
        age = MethodLibraries.ReadInt("Enter your age : ", 0, 100);
        Console.WriteLine("Age: " + age);
    }
}


