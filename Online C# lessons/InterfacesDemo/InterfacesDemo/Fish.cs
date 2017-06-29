using System;

namespace InterfacesDemo
{
    class Fish : IPrey, IPredator
    {
        private int _fleeSpeed;
        private int _attackSpeed;
        private string _name;


        public int FleeSpeed
        {
            get
            {
                return _fleeSpeed;
            }
            set
            {
                _fleeSpeed = value;
            }
        }


        public void Flee()
        {
            Console.WriteLine("Fish fleeing");
        }


        public int AttackSpeed
        {
            get
            {
                return _attackSpeed;
            }
            set
            {
                _attackSpeed = value;
            }
        }


        public void Attack(IPrey prey)
        {
            if (_attackSpeed > prey.FleeSpeed)
                Console.WriteLine("Caught prey");
            else
                Console.WriteLine("Prey escaped");
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
