using System;

namespace Chapter14
{
    internal class Employees
    {

        internal static void ShowEmployees()
        {
            Console.WriteLine("\nAll employees: ");
            // Declare the DbContext.
            FoodStoreEntities context = new FoodStoreEntities();

            // Get all Product objects in the DbSet named Employees. 
            var employees = context.Employees;

            // Display details for each Product object in Products DbSet.
            foreach (Employee employeeObject in employees)
            {
                Console.Write("ID: " + employeeObject.employee_id);
                Console.Write(", " + employeeObject.first_name + " ");
                Console.Write(employeeObject.last_name + " - ");
                Console.WriteLine("Branch: " + employeeObject.branch);
            }

        }
            
    }
}
