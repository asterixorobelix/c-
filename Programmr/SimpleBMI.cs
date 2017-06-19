/*
Write a C# program which can be used to calculate the body mass index (BMI). This is commonly used by health and nutrition professionals to estimate human body fat in populations.
BMI is computed by taking the individual's weight in kilograms and dividing it by the square of their height in meters. Output BMI to 4 decimal places, if decimals are non-zero. 
eg
Your Height in m: 1.75
Your Weight in kgs: 73
Your BMI is: 23.8367

Our Input	
2, 83
Expected Output	
20.75
*/

using System;

class SimpleBmiCalculator{
    
    static void Main(){
        double Height, Weight, BMI;
        
        Console.WriteLine("Please enter your height in meters: ");
        Double.TryParse(Console.ReadLine(),out Height);
        
        Console.WriteLine("Please enter your weight in meters: ");
        Double.TryParse(Console.ReadLine(),out Weight);
        
        BMI=Weight/Math.Pow(Height,2);
        
        Console.WriteLine("Your BMI is {0:#.####}",BMI);  //# means print a digit here if there is one.
    }
}