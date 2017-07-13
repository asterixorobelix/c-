using System;
using System.Collections.Generic;
using System.Data;
using System.Data.DataSetExtensions;

namespace ConsoleApp3
{
    internal class Program {
        public static void Main() {
            // Declare question with an integer and string response.
            QuizQuestion<int, string> question = new QuizQuestion<int, string>
                ("Approximately how many shark species exist?", 350, "None of the above.");
            question.ShowTypes();
            question.ShowQuestion();
            Console.ReadLine();
        }
    }
}
