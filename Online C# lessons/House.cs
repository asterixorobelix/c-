/*https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-exercise-7-2-House.aspx
Create a class "House", with an attribute "area", a constructor that sets its value and a method "ShowData" to display "I am a house, my area is 200 m2" (instead of 200, it will show the real surface). Include getters an setters for the area, too. 
The "House" will contain a door. Each door will have an attribute "color" (a string), and a method "ShowData" wich will display "I am a door, my color is brown" (or whatever color it really is). Include a getter and a setter. Also, create a "GetDoor" in the house. 
A "SmallApartment" is a subclass of House, with a preset area of 50 m2. 
Also create a class Person, with a name (string). Each person will have a house. The method "ShowData" for a person will display his/her name, show the data of his/her house and the data of the door of that house. 
Write a Main to create a SmallApartment, a person to live in it, and to show the data of the person.

Sample Output:
My name is Juan.
I am an apartment, my area is 50 m2
I am a door, my color is Brown.
*/

using System;
namespace Houses
{
    class House
    {
        protected int area;
        protected Door door;
 
        public House(int area)
        {
            this.area = area;
            door = new Door();
 
        }
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public Door Door
        {
            get { return door; }
            set { door = value; }
        }
 
        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2.", area);
        }
    }
 
    class Door
    {
        protected string color;
 
        public Door()
        {
            color = "Brown";
        }
        public Door(string color)
        {
            this.color = color;
        }
 
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
 
        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}.", color);
        }
 
    }
 
    class SmallApartment : House
    {
        public SmallApartment()
            : base(50)
        {
 
        }
        public override void ShowData()
        {
            Console.WriteLine("I am an apartment, my area is " +
                area + " m2");
        }
    }
 
    class Person
    {
        protected string name;
        protected House house;
 
        public Person()
        {
            name = "Juan";
            house = new House(150);
        }
        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }
 
        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();
        }
    }
 
    class TestHouse
    {
        static void Main()
        {
            SmallApartment mySmallApartament = new SmallApartment();
            Person myPerson = new Person();
 
            myPerson.Name = "Juan";
            myPerson.House = mySmallApartament;
            myPerson.ShowData();
        }
    }
}

