/*
Create a generic QuizQuestion class which stores quiz questions and answers in varying data formats. 
Create a QuizQuestion object which assigns an integer to the generic type. Then, create a second QuizQuestion object which assigns a string to the generic type.

Sample output:
Question: How many teeth do sharks have?
Answer: 300
Question: Which shark is the fastest swimmer?
Answer: The short fin mako shark
*/

namespace Example10point1{
	class Program{
		public static void Main(){
			QuizQuestion<int> question1 = new QuizQuestion<int>("How many teeth do sharks have?", 300);
			question1.ShowQandA();
			
			QuizQuestion<string> question2 = new QuizQuestion<string>("Which shark is the fastest swimmer?", "The short fin mako shark");
			question2.ShowQandA();
		}
	}
}