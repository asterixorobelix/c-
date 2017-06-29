
namespace InterfacesDemo
{
    interface IPrey : IAnimal
    {
        int FleeSpeed { get; set; }

        void Flee();
    }
}
