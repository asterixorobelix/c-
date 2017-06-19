/*Ask the user for several pieces of information mentioned below, and display them on the screen afterwards as a summary. Ask for the following:
first name
last name
grade (classification)
student id number
login name
GPA (0.0 to 4.0)
*/

using System;

class UserSummary{
    
    static void Main(){
        string FirstName, LastName, LoginName;
        char Grade;
        int IDNumber;
        double GPA;

        Console.WriteLine("Enter your first name:");
        FirstName=Console.ReadLine();
        
        Console.WriteLine("Enter your last name:");
        LastName=Console.ReadLine();
        
        
        Console.WriteLine("Enter your grade classification");
        Char.TryParse(Console.ReadLine(),out Grade);

        Console.WriteLine("Enter your student ID number:");
        int.TryParse(Console.ReadLine(),out IDNumber);

        Console.WriteLine("Enter your login name:");
        LoginName=Console.ReadLine();

        Console.WriteLine("Enter your GPA:");
        Double.TryParse(Console.ReadLine(), out GPA);        
    }
}