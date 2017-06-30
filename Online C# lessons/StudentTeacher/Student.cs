using System;

namespace ConsoleApp1
{
    internal class Student: Person //Internal types or members are accessible only within files in the same assembly
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }
}
