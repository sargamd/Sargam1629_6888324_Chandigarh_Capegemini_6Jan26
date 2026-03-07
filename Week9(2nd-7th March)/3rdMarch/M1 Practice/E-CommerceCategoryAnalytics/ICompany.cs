using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCategoryAnalytics
{
    internal interface ICompany
    {
        int Id { get; set; }
        string Name { get; set; }
        List<ICategory> Categories { get; set; }

        void AddCategory(ICategory category);
        string GetTopCategoryNameByProductCount();
        List<IProduct> GetProductsBelongsToMultipleCategory();
        (string, decimal) GetTopCategoryBySumOfProductPrices();
        List<(string, decimal)> GetCategoriesWithSumOfTheProductPrices();
    }
}
