//Please create a method TotalPrice(ILookup<string, Product> lookup) in which print(Name + " " + Price) from one category and total price for products from these categories (Key + " " + totalPriceForCategory)

//Expected:
//SmartTV 400
//Lenovo ThinkPad 1000
//Iphone 700
//Electronics 2100
//Orange 2
//Banana 3
//Fruits 5

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
            products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
            products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
            products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
            products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
            ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
            TotalPrice(lookup);
            Console.ReadKey();
        }

        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            foreach (var category in lookup)
            {
                foreach (var product in category)
                {
                    Console.WriteLine(product.Name + " " + product.Price);
                }
                Console.WriteLine(category.Key + " " + category.Sum(prod => prod.Price));
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
