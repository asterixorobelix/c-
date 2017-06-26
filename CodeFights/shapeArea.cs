using System;
class Shape{
	
	static void shapeArea(int n) {
		int sum=0;
		Console.WriteLine("Sum:"+sum);	
		for (int i =n;i>1;i--){
			
			sum+=(int) Math.Pow(i,2);  
			Console.WriteLine("Sum:"+sum);			
		}
		
	}

	static void Main(){
		int N=int.Parse(Console.ReadLine());
		shapeArea(N);
	}
}
