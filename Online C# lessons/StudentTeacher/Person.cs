/*(StudentTeacher)
https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-exercise-6-1-Classes-Student-Teacher.aspx
Create a class Person, which has an Age property and a public method called Greet, which takes no arguments and returns a greeting. 
The class Person must have a method "GetAge" which will indicate the value of their age (eg, 20 years old). 
Create a class "Student" and another class "Teacher", both descendants of "Person". 
The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class." 
The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string. 

Create a Person and make it say hello 
Create a student, set his age to 21, tell him to Greet and display his age 
Create a teacher, 30 years old, ask him to say hello and then explain. 

Sample Output:
Person constructor called
Hello!

Person constructor called
Student constructor called
My age is 21 years old
Hello!
I'm going to class
Person constructor called
Teacher constructor called
My age is 30 years old
Hello!
My explanation of Geography begins..
*/
using System;

namespace StudentTeacher{
	class Person{
		public int Age{get;set;}
		
		internal void Greet(){
			Console.WriteLine("Hello!");
		}
		
		internal void GetAge(){
			Console.WriteLine("My age is {0} years old",Age);
		}
		
		internal Person(int a){
			Age=a;
			Console.WriteLine("Person constructor called");
		}

		internal Person(){
			Age=10;
			Console.WriteLine("Person constructor called");
		}
		
	}	
}