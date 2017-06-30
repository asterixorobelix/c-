using System;

namespace ConstructorInheritanceDemo
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine("MyBaseClass constructor called.");
        }


        public MyBaseClass(int aNumber)
        {
            string output;
            output = string.Format("MyBaseClass created with value {0}.", aNumber);
            Console.WriteLine(output);
        }


        ~MyBaseClass()
        {
            Console.WriteLine("MyBaseClass destructor called.");
        }
    }
}
