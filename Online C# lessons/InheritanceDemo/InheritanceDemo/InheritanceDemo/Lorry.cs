
namespace InheritanceDemo
{
    class Lorry : MotorVehicle
    {
        private int _capacity;      // Cubic metres


        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
    }
}