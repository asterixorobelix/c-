/*
In order to compile this seperately:
cd into the folder containing the files.
Type:
csc *.cs
This will compile all .cs files in the folder into an exe, which will be named after the file containing the Main method.
https://mianlabs.com/2017/01/02/the-lazy-developers-guide-to-command-line-building-with-c/


https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-exercise-6-1-Classes-Student-Teacher.aspx
Create a class Person, which has private field called age and a public method called Greet, which takes no arguments and returns a greeting. 
Create a class "Student" and another class "Teacher", both descendants of "Person". 
The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class." 
The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string. 
The class Person must have a method "SetAge (int n)" which will indicate the value of their age (eg, 20 years old). 
The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number). 
You must create another test class called "StudentAndTeacherTest" that will contain "Main" and: 
Create a Person and make it say hello 
Create a student, set his age to 21, tell him to Greet and display his age 
Create a teacher, 30 years old, ask him to say hello and then explain. 

Sample Output:
Hello
Hello
My age is: 21 years old
Hello
Explanation begins
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();

            /*Create a student, set his age to 21, 
            tell him to Greet and display his age*/
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
            ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
}
