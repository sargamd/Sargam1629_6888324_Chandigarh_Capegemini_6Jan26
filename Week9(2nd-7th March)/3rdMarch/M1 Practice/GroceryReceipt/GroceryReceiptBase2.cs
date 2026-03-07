using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryReceipt
{
    abstract class GroceryReceiptBase2
    {
        public Dictionary<string, decimal> Prices { get; set; }
        public Dictionary<string, int> Discounts { get; set; }

        public GroceryReceiptBase2(Dictionary<string, decimal> prices, Dictionary<string, int> discounts)
        {
            Prices = prices;
            Discounts = discounts;
        }
        public abstract IEnumerable<(string fruit, decimal price, decimal total)> Calculate(List<Tuple<string, int>> shoppingList);
    }
}
