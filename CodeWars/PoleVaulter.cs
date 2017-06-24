/*
For a pole vaulter, it is very important to begin the approach run at the best possible starting mark. 
There is a guideline that will help a beginning vaulter start at approximately the right location, based on the vaulter's body height.
You are given the following two guidelines to begin with: (1) A vaulter with a height of 1.52 meters should start at 9.45 meters on the runway. 
(2) A vaulter with a height of 1.83 meters should start at 10.67 meters on the runway.

You will receive a vaulter's height in meters. Your job is to return the best starting mark in meters, rounded to two decimal places.

Sample Output:
Enter your height:
1.23
Your ideal StartingMark is 8.31 m from the vault

Enter your height:
a
That input was not recognized
*/

using System;

class PoleVault
{
    public static double StartingMark(double bodyHeight)
    {
    	//y=mx+c
    	//m=  DeltaY/DeltaX	 

    	const double m=(10.67-9.45)/(1.83-1.52);
    	const double c= 10.67-m*1.83;

    	return Math.Round(m*bodyHeight+c,2);
    }

    static void Main(){
    	Console.WriteLine("Enter your height:");

    	double Height;

    	try{

    		Height=double.Parse(Console.ReadLine());

    		Console.WriteLine("Your ideal StartingMark is {0:0.00} m from the vault",StartingMark(Height));
    	}

    	catch{
    		Console.WriteLine("That input was not recognized");
    	}
    }
}
