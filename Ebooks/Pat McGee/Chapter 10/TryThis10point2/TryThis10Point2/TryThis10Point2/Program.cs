/*pg 313, TryThis10.2- pat mcgee
Write a program which has a list of integers.
Add, display, insert, and remove the List items in a manner which generates the following output exactly:
Adding items: 1, 8
*** Inserting one item: 1, 2, 8
*** Inserting range of items: 1, 2, 3, 4, 5, 6, 7, 8
*** Removing range of two items: 1, 4, 5, 6, 7, 8
*** Removing item by object: 1, 4, 5, 6, 8
*** Removing item by index: 4, 5, 6, 8
The first item is 4
*** Clearing all items
*/

using System;
using System.Collections.Generic;

namespace TryThis10Point2
{
    class Program
    {
        static void Main()
        {
            List<int> IntegerList = new List<int>();

            Console.WriteLine("Adding 1,8");
            IntegerList.Add(1);
            IntegerList.Add(8);

            Console.WriteLine("Inserting 2 between 1 and 8");
            IntegerList.Insert(2, 1);

            Console.WriteLine("Inserting range of items, from 4 to 6, at the end of list");
            List<int> SubList = new List<int>();
            IntegerList.InsertRange(3);
        }
    }
}
