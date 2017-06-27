/*
Given an array of integers, find the pair of adjacent elements which has the largest absolute value product and return that product. Include a way to use your code with different arrays.

[input] array.integer inputArray: An array of integers containing at least two elements.
[output] integer : The largest product of adjacent elements.

Guaranteed constraints:
2 ≤ inputArray.length ≤ 10,
-1000 ≤ inputArray[i] ≤ 1000.

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
	
	//Finds the largest absolute value product of adjacent elements in an array
	static void CalculateAdjacentElementsProduct(int[] inputArray) {
		int BiggestProduct=0;
		int Product;
		int a1=0,a2=0;
		
		for(int i=0;i<inputArray.Length-1;i++){
			Product=Math.Abs(inputArray[i]*inputArray[i+1]);
			
			if(Product>BiggestProduct){
				BiggestProduct=Product;
				a1=inputArray[i];
				a2=inputArray[i+1];
			}
		}
		Console.WriteLine("\nThe largest product of adjacent elements is: {0} which is {1}*{2}",BiggestProduct, a1,a2);
	}
	
	//Generates an array of random numbers between a specified min and max. The array is of a random size between a specified min and max. Has default parameters.
	static int[] CreateRandomArray(int MinValue=2, int MaxValue=10, int ArrayMin = -1000, int ArrayMax=1000){
			
		Random Rand = new Random();//Make an object of type Random
		int ArrayLength = Rand.Next(MinValue,MaxValue); //Use the Rand object from above in order to generate a random number between 2 (inclusive) and 10 (exclusive)
		//Next(minValue, MaxValue) minValue(inclusive); maxValue (exclusive).
				
		int[] RandomArray=new int[ArrayLength];
		
		Console.WriteLine("Random array:");
		
		for(int i=0;i<ArrayLength;i++){
			int ArrayEntry = Rand.Next(ArrayMin,ArrayMax);//Generate a random number between ArrayMin and ArrayMax.
			Console.Write(" "+ArrayEntry);
			RandomArray[i]=ArrayEntry;
		}
		return RandomArray;
	}
	
	static void Main(){
				
		int[] Array=CreateRandomArray();
		
		CalculateAdjacentElementsProduct(Array);					
	}
}