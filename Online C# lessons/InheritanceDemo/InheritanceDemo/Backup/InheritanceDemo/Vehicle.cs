using System;

namespace InheritanceDemo
{
    public class Vehicle
    {
        protected int _speed;     // Miles per hour

        public int Speed
        {
            get
            {
                return _speed;
            }
        }


        public void Accelerate(int mph)
        {
            _speed += mph;
        }


        public void Decelerate(int mph)
        {
            _speed -= mph;
        }


        public virtual void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Turning left");
            else
                Console.WriteLine("Turning right");
        }
    }
}
