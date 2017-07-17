/*Page 472, chapter 16, self test exercise 5 from Pat McGee
Create a program to select and display productID, name, mfg, vendor, and price column values of the Product
table from the FoodStore database for any product named “Cake Mix” or “Cookie Dough”.

Sample Output:
Products containing Cookie Dough in the name:
2-Cookie Dough-Duncan Hines-Sysco-1,2500
4-Cookie Dough-Pilsbury-GFS-1,4500
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTest16Point4
{
    class GetProducts
    {
        internal static void GetProduct(string term)
        {
            FoodStoreEntities db = new FoodStoreEntities();

            var products = db.Products
                .Select(p => new { ID = p.productID, Name = p.name, Manufacturer = p.mfg, Vendor = p.vendor, Price = p.price })
                .Where(p => p.Name == term);

            Console.WriteLine("Products containing {0} in the name: ", term);

            foreach (var product in products)
            {
                
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}", product.ID, product.Name, product.Manufacturer, product.Vendor, product.Price);
            }
        }
    }
}
