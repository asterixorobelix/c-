/*pg 410 of McGee
First define a DbContext object which references the FoodStore database. Implicitly define a product list with the var keyword. 
The compiler knows to create a list of products because the variable is assigned the Products DbSet which is retrieved with the DbContext object. 
The properties associated with each Product entity object take the names and types from the columns of the Product table. 
These properties were actually set up for the Product entity when the EDM was generated. 
When the data is needed, the Entity Framework generates SQL and sends it to the database to get the data. 
This code effectively retrieves all rows from the Product table and returns it to the application, which then displays the data.

Sample Output:
1: Cake Mix - Sysco - R2,99
2: Cookie Dough - Sysco - R1,25
3: Orange Juice - GFS - R4,25
4: Cookie Dough - GFS - R1,45
5: Carrots - GFS - R1,01
*/

using System;

namespace Chapter14
{
    internal class Program
    {
        private static void Main()
        {
            // Declare the DbContext.
            FoodStoreEntities context = new FoodStoreEntities();

            // Get all Product objects in the DbSet named Products. Basically, everything in the Products table
            var products = context.Products;

            // Display details for each Product object in Products DbSet.
            foreach (Product productObject in products)
            {
                Console.Write(productObject.productID.ToString() + ": ");
                Console.Write(productObject.name + " - ");
                Console.Write(productObject.vendor + " - ");
                decimal price = (decimal)productObject.price;
                string priceStr = price.ToString("C"); //output a number in the local currency format, by passing the letter “C” to the ToString() method
                Console.WriteLine(priceStr);
            }
            Console.ReadLine();
        }
    }
}
