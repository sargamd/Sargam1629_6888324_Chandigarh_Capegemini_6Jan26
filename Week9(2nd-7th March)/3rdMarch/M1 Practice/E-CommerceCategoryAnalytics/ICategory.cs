using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCategoryAnalytics
{
    internal interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }
        List<IProduct> Products { get; set; }
        void AddProduct(IProduct product);
    }
}
