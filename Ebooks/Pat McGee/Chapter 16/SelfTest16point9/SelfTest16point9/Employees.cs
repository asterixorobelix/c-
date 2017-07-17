/* Self test 16.9, pg 473 of McGee
Write a program that uses method-based syntax to query the Employee
table of the FoodStore database to show first_name and last_name column
values for all employees with a first name starting with the letter “J”.

Sample Output:
Employees whose first name begins with J:
Jane Chen
Jeff Johnson

Employees whose first name begins with B:
Baljeet Singh
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTest16point9
{
    class Employees
    {
        internal static void EmployeeSelect(string letter)
        {
            FoodStoreEntities db = new FoodStoreEntities();

            var employee = db.Employees
                .Select(e=> new { First = e.first_name, Last=e.last_name})
                .Where(e => e.First.StartsWith(letter));

            Console.WriteLine("Employees whose first name begins with {0}: ", letter);

            foreach(var emp in employee)
            {
                Console.WriteLine("{0} {1}", emp.First, emp.Last);
            }
        }
    }
}
