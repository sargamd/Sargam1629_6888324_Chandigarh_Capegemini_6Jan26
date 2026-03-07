namespace Product_Inventory_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                Product p = new Product
                {
                    Name = data[0],
                    Category = data[1],
                    Stock = Convert.ToInt32(data[2]),
                    Price = Convert.ToInt32(data[3])
                };

                inventory.AddProduct(p);
            }

            string categorySearch = Console.ReadLine();
            string nameSearch = Console.ReadLine();
            string removeProductName = Console.ReadLine();

            Console.WriteLine(categorySearch + ":");

            foreach (var p in inventory.GetProductsByCategory(categorySearch))
            {
                Console.WriteLine($"Product Name:{p.Name} Category:{p.Category}");
            }

            Console.WriteLine($"Total Value:${inventory.CalculateTotalValue()}");

            foreach (var item in inventory.GetProductsByCategoryWithCount())
            {
                Console.WriteLine($"{item.Item1}:{item.Item2}");
            }

            foreach (var group in inventory.GetAllProductsByCategory())
            {
                Console.WriteLine(group.Item1 + ":");

                foreach (var p in group.Item2)
                {
                    Console.WriteLine($"Product Name:{p.Name} Price:{p.Price}");
                }
            }

            var removeProduct = new Product { Name = removeProductName };
            inventory.RemoveProduct(removeProduct);

            Console.WriteLine($"New Total Value:${inventory.CalculateTotalValue()}");
        }
    }
    
}
