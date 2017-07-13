/*pg 307 - pat mcgee
Create a generic QuizQuestion class which stores one quiz question and two answers in varying data formats. 
Then, create some QuizQuestion objects which assigns a string to the generic type.

Sample output:
Question: How many teeth do sharks have?
Answer: 300
Question: Which shark is the fastest swimmer?
Answer: The short fin mako shark
*/
using System;

namespace ConsoleApp3
{
    // Declare class that implements two generic types.
    internal class QuizQuestion<T, U> {
        private string Question { set; get; }
        private T ResponseA;
        private U ResponseB;
        
        // Constructor.
        public QuizQuestion(string question, T a, U b) {
            Question  = question;
            ResponseA = a;
            ResponseB = b;
        }

        // Show data types.
        public void ShowTypes() {
            Console.WriteLine("(a) is a " + typeof (T).ToString());
            Console.WriteLine("(b) is a " + typeof (U).ToString());
        }

        public void ShowQuestion() {
            Console.WriteLine(Question);
            Console.WriteLine("a) " + ResponseA.ToString());
            Console.WriteLine("b) " + ResponseB.ToString());
        }
    }
}