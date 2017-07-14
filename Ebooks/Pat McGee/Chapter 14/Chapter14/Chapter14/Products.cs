using System;
using System.Linq;

namespace Chapter14
{
    internal class Products
    {
        internal static void DisplayProducts()
        {
            Console.WriteLine("\nAll products: ");
            // Declare the DbContext.
            FoodStoreEntities context = new FoodStoreEntities();

            var products = context.Products;

            foreach(Product productObject in products)
            {
                Console.WriteLine("ID: {0}, Name: {1}, - {2} - R{3:0.00} ",productObject.productID, productObject.name, productObject.vendor, productObject.price);
            }

        }

        internal static void DisplayProductsRange(decimal a, decimal b)
        {
            Console.WriteLine("\nProducts with a price between {0} and {1}", a, b);

            FoodStoreEntities db = new FoodStoreEntities();

            var products = db.Products.Where(p => p.price > a && p.price < b);

            foreach (Product p in products)
            {
                Console.WriteLine("ID: {0}, Name: {1}, - {2} - R{3:0.00} ", p.productID, p.name, p.vendor, p.price);
            }
        }
    }
}
