/* Step through the code in Visual Studio by pressing F11.
 * Use the Locals window and the console output to see the results */

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPredator shark = new Fish();
            shark.AttackSpeed = 30;

            IPrey ray = new Fish();
            ray.FleeSpeed = 15;

            shark.Attack(ray);
        }
    }
}
