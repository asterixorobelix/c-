/*
 * pg 305, Example10.2- pat mcgee
Create a generic QuizQuestion class which stores quiz questions and answers in varying data formats. 
Create a QuizQuestion object which assigns an integer and a string to the generic type.

Sample Output:
Question How many shark species exist?
A) 350
B) None of the above
*/
namespace Ex10point2
{
    class Program
    {
        static void Main()
        {
            QuizQuestion<int, string> Q1 = new QuizQuestion<int,string>("How many shark species exist?", 350, "None of the above");
            Q1.showQA();
        }
    }
}
