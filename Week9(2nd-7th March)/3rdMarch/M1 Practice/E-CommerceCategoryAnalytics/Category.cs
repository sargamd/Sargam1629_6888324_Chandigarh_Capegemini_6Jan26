using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCategoryAnalytics
{
    internal class Category:ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProduct> Products { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }
    }
}
