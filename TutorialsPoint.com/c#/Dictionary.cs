/*
Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.

Here is the inventory specification:

3 of type apple
5 of type orange
2 of type banana
*/

using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory["apple"] = 3;
        inventory["orange"] = 5;
        inventory["banana"] = 2;

        Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);

    }
}