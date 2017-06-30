/*
http://www.dotnetbull.com/2013/10/public-protected-private-internal-access-modifier-in-c.html
Internal: - Internal members are accessible only within the assembly by inheritance or by instance of that class. So, internal is for assembly scope (i.e. only accessible from code in the same .exe or .dll)
Private is for class scope (i.e. accessible only from code in the same class).
*/

using System;

namespace ConsoleApp1
{
    internal class Person //Internal types or members are accessible only within files in the same assembly
    {
        protected int age; //The protected type or member can be accessed only by code in the same class or struct, or in a class which is derived from that class.
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }

    }
}