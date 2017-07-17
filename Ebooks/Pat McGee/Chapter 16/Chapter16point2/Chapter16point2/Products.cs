/*
pg 461 of McGee, chapter 16
Write a program which contains a method, DisplayProductsRange, which selects and prints to the console items which fall within that range.

Products with a price between 1 and 1,3
Cookie Dough - R1,25
Carrots - R1,01
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16point2
{
    class Products
    {
        internal static void DisplayProductsRange(decimal a, decimal b)
        {
            FoodStoreEntities db = new FoodStoreEntities();

            var products = db.Products.Where(prod=>(prod.price>a && prod.price<b));
            Console.WriteLine("Products with a price between {0} and {1}", a, b);

            foreach (Product p in products)
            {                
                Console.WriteLine("{0} - R{1:0.00}",p.name, p.price);
            }
        }
    }
}
