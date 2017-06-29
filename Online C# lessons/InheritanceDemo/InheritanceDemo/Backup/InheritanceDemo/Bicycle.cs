using System;

namespace InheritanceDemo
{
    class Bicycle : Vehicle
    {
        public void RingBell()
        {
            Console.WriteLine("Ring!");
        }


        public override void Indicate(bool turningLeft)
        {
            base.Indicate(turningLeft);

            if (turningLeft)
                Console.WriteLine("Raising left arm");
            else
                Console.WriteLine("Raising right arm");
        }

    }
}