using System;

namespace Ex10point2
{
    class QuizQuestion<T,U>
    {
        public T Response1 { get; set; }
        public U Response2 { get; set; }
        public string  Question { get; set; }

        internal QuizQuestion(string Q,T a1, U a2)
        {
            Response1 = a1;
            Response2 = a2;
            Question = Q;
        }

        public void showQA() {
            Console.WriteLine("Question {0}", Question);
            Console.WriteLine("A) " + Response1);
            Console.WriteLine("B) " + Response2);
        }
    }
}
