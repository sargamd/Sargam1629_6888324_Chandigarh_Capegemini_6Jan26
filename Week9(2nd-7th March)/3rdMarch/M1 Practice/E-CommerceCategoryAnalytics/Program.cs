namespace E_CommerceCategoryAnalytics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company(1, "Shop");

            Category c1 = new Category(1, "Category1");
            Category c2 = new Category(2, "Category2");

            Product p1 = new Product(1, "Product1", 10);
            Product p2 = new Product(2, "Product2", 15);
            Product p3 = new Product(3, "Product3", 20);
            Product p4 = new Product(4, "Product4", 10);
            Product p5 = new Product(5, "Product5", 5);
            Product p6 = new Product(6, "Product6", 30);

            c1.AddProduct(p1);
            c1.AddProduct(p2);
            c1.AddProduct(p3);
            c1.AddProduct(p4);

            c2.AddProduct(p2);
            c2.AddProduct(p3);
            c2.AddProduct(p4);
            c2.AddProduct(p5);
            c2.AddProduct(p6);

            company.AddCategory(c1);
            company.AddCategory(c2);

            Console.WriteLine("Top category:" + company.GetTopCategoryNameByProductCount());

            Console.WriteLine("Common products:");
            foreach (var p in company.GetProductsBelongsToMultipleCategory())
            {
                Console.WriteLine(p.Name);
            }

            var topValue = company.GetTopCategoryBySumOfProductPrices();
            Console.WriteLine("Most valuable category:" + topValue.Item1 + " " + topValue.Item2);

            foreach (var item in company.GetCategoriesWithSumOfTheProductPrices())
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }
        }
    }
    
}
