/*
Given an array of integers, find the pair of adjacent elements which has the largest absolute value product and return that product. Include a way to use your code with different arrays.

[input] array.integer inputArray: An array of integers containing at least two elements.

Guaranteed constraints:
2 ≤ inputArray.length ≤ 10,
-1000 ≤ inputArray[i] ≤ 1000.

[output] integer : The largest product of adjacent elements.

Sample Output:
Random array:
 -559 -435 738
The largest product of adjacent elements is: 321030 which is -435*738

Random array:
 -739 -231 -905
The largest product of adjacent elements is: 209055 which is -231*-905

Random array:
 -200 194 429 647 404
The largest product of adjacent elements is: 277563 which is 429*647
*/

using System;

class AdjacentElements{
	static int adjacentElementsProduct(int[] inputArray, out int a1, out int a2) {
		int BiggestProduct=0;
		int Product;
		a1=a2=0;
		
		for(int i=0;i<inputArray.Length-1;i++){
			Product=Math.Abs(inputArray[i]*inputArray[i+1]);
			
			if(Product>BiggestProduct){
				BiggestProduct=Product;
				a1=inputArray[i];
				a2=inputArray[i+1];
			}
		}
			return BiggestProduct;
	}
	
	static void Main(){
		Random ArrL = new Random();
		int ArrayLength = ArrL.Next(2,10);
		int adjacent1, adjacent2;
		
		int[] RandomArray=new int[ArrayLength];
		
		Random ArrEnt = new Random ();
		Console.WriteLine("Random array:");
		
		for(int i=0;i<ArrayLength;i++){
			int ArrayEntry = ArrEnt.Next(-1000,1000);
			Console.Write(" "+ArrayEntry);
			RandomArray[i]=ArrayEntry;
		}
		
		int BiggestResult = adjacentElementsProduct(RandomArray, out adjacent1, out adjacent2);
		
		Console.WriteLine("\nThe largest product of adjacent elements is: {0} which is {1}*{2}",BiggestResult, adjacent1,adjacent2);			
	}

}