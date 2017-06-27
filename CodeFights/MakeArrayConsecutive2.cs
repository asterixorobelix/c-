/*
Ratiorg got statues of different sizes as a present from his CodeMaster for his birthday, each statue having an non-negative integer size. 
Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one by exactly 1. 
He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.

Example
For statues = [6, 2, 3, 8], the output should be makeArrayConsecutive2(statues) = 3. Ratiorg needs 3 statues of sizes 4, 5 and 7.

Input/Output
[input] array.integer statues: An array of distinct non-negative integers.
[output] integer : The minimal number of statues that need to be added to existing statues such that it contains every integer size from an interval [L, R] (for some L, R) and no other sizes.

Guaranteed constraints:
1 ≤ statues.length ≤ 10
0 ≤ statues[i] ≤ 20

Tests:
Input: statues = [5, 4, 6]
Expected Output: 0
*/

using System;

class ArrayConsecutive{
	
	static int[] CreateRandomArray(int ArrayMin=1, int ArrayMax=10, int EntryMin=0, int EntryMax=20){
		Random Rnd= new Random();
		int RandomArrayLength= Rnd.Next(ArrayMin,ArrayMax);
				
		int[]RandomArray=new int[RandomArrayLength];
		Console.WriteLine("Random Array");
		
		for(int i=0;i<RandomArrayLength;i++){
			int ArrayEntry=Rnd.Next(EntryMin,EntryMax);
			RandomArray[i]=ArrayEntry;	
			Console.Write(" "+ArrayEntry);
		}
		return RandomArray;
	}
	
	static int MakeArrayConsecutive(int[] StatArray){
		Array.Sort(StatArray);
		
		int RequiredStatues=0;
		int AdjacentDifference=0;
		
		Console.WriteLine("\nSorted Array");
		foreach(int j in StatArray){
			Console.Write(" "+j);
		}
		
		for (int i=0;i<StatArray.Length-1;i++){
			
			AdjacentDifference=StatArray[i+1]-StatArray[i];
			
			if(AdjacentDifference!=1){
				RequiredStatues+=(AdjacentDifference-1);
			}			
		}
		return RequiredStatues;
	}
	
	//OR
	/*
	int makeArrayConsecutive2(int[] statues) {
    var min = statues.Min();
    var max = statues.Max();
    
    return max - min - statues.Length + 1;
	}
	*/
	
	static void Main(){
		//int[] Statues = CreateRandomArray();//The problem is that although the generated array is random, the entries are not unique. eg: 1 8 12 13 15 15 15 19 19
		int[] Statues = {6, 2, 3, 8};
		int AdditionalStatues=MakeArrayConsecutive(Statues);
		Console.WriteLine("\nThe required number of statues is "+AdditionalStatues);		
	}	
}