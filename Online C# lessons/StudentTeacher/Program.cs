/*
https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-exercise-6-1-Classes-Student-Teacher.aspx
Create a class Person, which has private field called age and a public method called Greet, which takes no arguments and returns a greeting. 
Create a class "Student" and another class "Teacher", both descendants of "Person". 
The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class." 
The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string. 
The class Person must have a method "SetAge (int n)" which will indicate the value of their age (eg, 20 years old). 
The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number). 
You must create another test class called "StudentAndTeacherTest" that will contain "Main" and: 
Create a Person and make it say hello 
Create a student, set his age to 21, tell him to Greet and display his age and go to class. 
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

namespace StudentTeacher
{
    class Program
    {
        static void Main()
        {
            //Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();
			
			Console.WriteLine();
            /*Create a student, set his age to 21, 
            tell him to Greet and display his age*/
            Student myStudent = new Student(21);
            myStudent.GetAge();
            myStudent.Greet();
			myStudent.GoToClasses();
            
            /*Create a teacher, 30 years old, 
            ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher(30);
            myTeacher.GetAge();
            myTeacher.Greet();
            myTeacher.Explain("Geography");
        }
    }
}
