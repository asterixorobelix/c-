/*
Create a console application which references the FoodStore database.
Create a program which allows you to select and display the branch and building_name column values from the Store table of the FoodStore database for all stores which are located in a certain region.

Sample Output:

You selected the state: WA
Seattle - Fairlane Square

You selected the state: BC
Kamloops - Vineyard Estates
Mission - Peaceful Place
Richmond -
Vancouver - City Center
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryThis16point1
{
    internal class Stores
    {
        internal static void GetStores(string state)
        {
            Console.WriteLine("You selected the state: " + state);
            FoodStoreEntities db = new FoodStoreEntities();

            var store = db.Stores
                .Select(stor => new { stor.branch, Name=stor.building_name, Region = stor.region})
                .Where(stor=>stor.Region == state);

            foreach(var s in store)
            {
                Console.WriteLine("{0} - {1}", s.branch, s.Name);
            }
        }
    }
}
