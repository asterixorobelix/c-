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
	class Teacher:Person{
		
		public string Subject{get;set;}
		
		internal void Explain(string sub){
			Subject = sub;
			Console.WriteLine("My explanation of {0} begins..",Subject);
		}
		
		//Unlike classes, constructors that are declared within a base class are not inherited by subclasses
		public Teacher(int a):base(a){
			Console.WriteLine("Teacher constructor called");
		}
	}
}