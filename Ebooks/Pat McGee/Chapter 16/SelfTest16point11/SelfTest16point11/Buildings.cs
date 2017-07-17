/*
Select a list of unique building_name columns
from the Building table in the FoodStore database. 

Sample Output:
All buildings:
City Center
City Center
Fairlane Square
Peaceful Place
Vineyard Estates
There are 5 buildings in the db

Unique Buildings:
City Center
Fairlane Square
Peaceful Place
Vineyard Estates
There are 4 unique buildings in the list
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTest16point11
{
    class Buildings
    {
        internal static void UniqueBuildings()
        {
            int count = 0;
            FoodStoreEntities db = new FoodStoreEntities();

            var building = db.Buildings
                .Select(b => new { Name = b.building_name }).Distinct();

            Console.WriteLine("Unique Buildings:");

            foreach (var build in building)
            {
                Console.WriteLine(build.Name);
                count++;
            }
            Console.WriteLine("There are {0} unique buildings in the list", count);

        }

        internal static void AllBuildings()
        {
            int count = 0;
            FoodStoreEntities db = new FoodStoreEntities();

            var buildings = db.Buildings
                            .Select(b => new { Name = b.building_name });

            Console.WriteLine("All buildings:");

            foreach (var b in buildings)
            {
                Console.WriteLine(b.Name);
                count++;
            }
            Console.WriteLine("There are {0} buildings in the db", count);
        }
    }
}
