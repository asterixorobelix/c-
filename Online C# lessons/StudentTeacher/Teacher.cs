using System;

namespace ConsoleApp1
{
    internal class Teacher : Person //Internal types or members are accessible only within files in the same assembly
    {
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}