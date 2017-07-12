/*
Page 81 of Rob Miles c# book.
Code Sample 22
Demonstrate how to limit the states of a TrafficLight to only Red,Green and Amber.
*/

using System;

enum TrafficLight
{
    Red,
    Green,
    Amber
} ;

class EnumDemonstration
{

    public static void Main()
    {
        TrafficLight light;
        light = TrafficLight.Red;
        Console.WriteLine(light);
    }
}
