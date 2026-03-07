using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Management
{
    internal interface IInventory
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        int CalculateTotalValue();
        List<IProduct> GetProductsByCategory(string category);
        List<(string, int)> GetProductsByCategoryWithCount();
        List<IProduct> SearchProductsByName(string name);
        List<(string, List<IProduct>)> GetAllProductsByCategory();
    }
}
