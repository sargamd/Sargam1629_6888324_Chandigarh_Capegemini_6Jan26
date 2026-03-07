using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCategoryAnalytics
{
    internal class Company:ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ICategory> Categories { get; set; }

        public Company(int id, string name)
        {
            Id = id;
            Name = name;
            Categories = new List<ICategory>();
        }

        public void AddCategory(ICategory category)
        {
            Categories.Add(category);
        }

        public string GetTopCategoryNameByProductCount()
        {
            return Categories
                .OrderByDescending(c => c.Products.Count)
                .First().Name;
        }

        public List<IProduct> GetProductsBelongsToMultipleCategory()
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            Dictionary<string, IProduct> productRef = new Dictionary<string, IProduct>();

            foreach (var cat in Categories)
            {
                foreach (var p in cat.Products)
                {
                    if (!count.ContainsKey(p.Name))
                    {
                        count[p.Name] = 0;
                        productRef[p.Name] = p;
                    }

                    count[p.Name]++;
                }
            }

            List<IProduct> result = new List<IProduct>();

            foreach (var item in count)
            {
                if (item.Value > 1)
                    result.Add(productRef[item.Key]);
            }

            return result;
        }

        public (string, decimal) GetTopCategoryBySumOfProductPrices()
        {
            var data = Categories
                .Select(c => new
                {
                    Category = c.Name,
                    Total = c.Products.Sum(p => p.Price)
                })
                .OrderByDescending(x => x.Total)
                .First();

            return (data.Category, data.Total);
        }

        public List<(string, decimal)> GetCategoriesWithSumOfTheProductPrices()
        {
            List<(string, decimal)> result = new List<(string, decimal)>();

            foreach (var c in Categories)
            {
                decimal sum = c.Products.Sum(p => p.Price);
                result.Add((c.Name, sum));
            }

            return result;
        }
    }
}
