/*pg 305 - pat mcgee
Create a generic QuizQuestion class which stores quiz questions and answers in varying data formats. 
Create a QuizQuestion object which assigns an integer to the generic type. Then, create a second QuizQuestion object which assigns a string to the generic type.

Sample output:
Question: How many teeth do sharks have?
Answer: 300
Question: Which shark is the fastest swimmer?
Answer: The short fin mako shark
*/
using System;

namespace Example10point1{
	internal class QuizQuestion<T> {
		//properties
		public T Answer{get;private set;}
		private string Question {get;set;}
		
		public QuizQuestion(string question, T answer){//constructor
			Question=question;
			Answer=answer;
		}
		
		public void ShowQandA(){
			Console.WriteLine("Question: "+Question);
			Console.WriteLine("Answer: "+Answer.ToString());//catering for the possibility that answer is not of type string.
		}
	}
}