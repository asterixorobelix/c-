using System;

namespace ConstructorInheritanceDemo
{
    class MySubclass : MyBaseClass
    {
        public MySubclass()
        {
            Console.WriteLine("MySubclass constructor called.");
        }


        public MySubclass(int startValue) : base(startValue)
        {
            string output;
            output = string.Format("MySubclass created with value {0}.", startValue);
            Console.WriteLine(output);
        }


        ~MySubclass() //Destructor
        {
            Console.WriteLine("MySubclass destructor called.");
        }
    }
}
