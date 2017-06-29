
namespace InterfacesDemo
{
    interface IPredator : IAnimal
    {
        int AttackSpeed { get; set; }

        void Attack(IPrey prey);
    }
}