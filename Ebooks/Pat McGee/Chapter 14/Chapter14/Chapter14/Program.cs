/*pg 412 of McGee
Create a program which can look at the Foodstore database and displays the Products and Employees in the database.

Sample Output:
All products:
ID: 1, Name: Cake Mix, - Sysco - R2,99
ID: 2, Name: Cookie Dough, - Sysco - R1,25
ID: 3, Name: Orange Juice, - GFS - R4,25
ID: 4, Name: Cookie Dough, - GFS - R1,45
ID: 5, Name: Carrots, - GFS - R1,01

All employees:
ID: 9001, Jane Chen - Branch: Vancouver
ID: 9002, Jeff Johnson - Branch: Kamloops
ID: 9003, Pam Rogers - Branch: Richmond
ID: 9004, Baljeet Singh - Branch: Seattle
*/

using System;

namespace Chapter14
{
    internal class Program
    {
        private static void Main()
        {
            Products.DisplayProducts();
            Employees.ShowEmployees();
            
        }
    }
}
