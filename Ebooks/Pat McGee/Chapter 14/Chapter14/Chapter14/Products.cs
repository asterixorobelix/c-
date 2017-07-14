using System;

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
    }
}
