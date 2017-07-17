/*pg 472 of McGee, Self test 16.3
Create a console app which connects to the Foodstore database.
Create a method called GetEmployeeNames which can retrieve all first_names and last_names of employees, provided that their employee ID is greater than 9002.

Sample Output:
Pam-Rogers
Baljeet-Singh
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTest16point3
{
    class Employees
    {
        internal static void GetEmployeeNames()
        {
            FoodStoreEntities db = new FoodStoreEntities();

            var Employees = db.Employees //look at the Employees table in the database
                .Select(e => new { e.first_name, e.last_name, e.employee_id })
                .Where(e => e.employee_id > 9002);

            foreach(var e in Employees)
            {
                Console.WriteLine("{0}-{1}", e.first_name, e.last_name);
            }
        }
        
    }
}
