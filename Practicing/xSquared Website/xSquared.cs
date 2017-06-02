using System;

namespace xSquaredApp{
    
    class xSquared{
    
        static void Main()
        {
        Console.WriteLine("Enter a number to square: ");
        int number;
        String userInput;
        userInput=Console.ReadLine();
        
        Console.WriteLine("You entered {0}", userInput);
        
        Int32.TryParse(userInput, out number);//parses string into int
        
        double numberSquared=Math.Pow(number, 2);
        
        Console.WriteLine("{0} squared is {1}",userInput,numberSquared);
        
            
        }   
    
    }
    
    
}



