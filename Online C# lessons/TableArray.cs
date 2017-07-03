/*https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-exercise-7-1-Array-of-objects-table.aspx
Create a class named "Table". It must have a constructor, indicating the width and height of the board. 
It will have a method "ShowData" which will write on the screen the width and that height of the table. 
Create an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data.

Sample Output:
Width: 83, Heigth: 161
Width: 124, Heigth: 64
Width: 138, Heigth: 171
Width: 117, Heigth: 133
Width: 127, Heigth: 120
Width: 121, Heigth: 61
Width: 119, Heigth: 74
Width: 112, Heigth: 77
Width: 58, Heigth: 107
Width: 121, Heigth: 107
*/
using System;
namespace ArrayOfObjects
{
    class Table
    {
        private float _width, _height;
 
        public Table()
        {
        }
		
        public Table(float width, float height)
        {
            Width = width;
            Height =height;
        }
 
        public float Width
        {
            set { _width = value; }
            get { return _width; }
        }
        public float Height
        {
            set { _height = value; }
            get { return _height; }
        }
 
        public void ShowData()
        {
            Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
        }
    }
 
    class TestTables
    {
        static void Main()
        {
            Table[] myTables = new Table[10];//Creating an array containing the type Table.
            Random rnd = new Random();
 
            for (int i = 0; i < 10; i++)
            {
                myTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));//Create a new Table object.
                myTables[i].ShowData();
            }
        }
    }
}