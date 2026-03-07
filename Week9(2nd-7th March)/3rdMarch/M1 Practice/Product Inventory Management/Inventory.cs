using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Management
{
    internal class Inventory:IInventory
    {
        private List<IProduct> _products=new List<IProduct>();
        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }
        public void RemoveProduct(IProduct product)
        {
            _products.Remove(product);
        }

        public int CalculateTotalValue()
        {
            int total = 0;
            foreach(var item in _products)
            {
                total = total + item.Price;
            }
            return total;
        }
        public List<IProduct> GetProductsByCategory(string category)
        {
            return _products.Where(p=>p.Category==category).ToList();
            
        }
        public List<(string,int)> GetProductsByCategoryWithCount()
        {
           
             return _products
            .GroupBy(p => p.Category)
            .Select(g => (g.Key, g.Count()))
            .ToList();

            
        }
        public List<IProduct> SearchProductsByName(string name)
        {
            return _products
                .Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<(string, List<IProduct>)> GetAllProductsByCategory()
        {
            return _products
                .GroupBy(p => p.Category)
                .Select(g => (g.Key, g.ToList()))
                .ToList();
        }
    }
}
