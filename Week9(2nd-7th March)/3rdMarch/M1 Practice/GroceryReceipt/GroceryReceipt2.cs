using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryReceipt
{
    internal class GroceryReceipt2:GroceryReceiptBase2
    {
        public GroceryReceipt2(Dictionary<string, decimal> prices, Dictionary<string, int> discounts)
        : base(prices, discounts)
        {
        }

        public override IEnumerable<(string fruit, decimal price, decimal total)>
        Calculate(List<Tuple<string, int>> shoppingList)
        {
            List<(string fruit, decimal price, decimal total)> result =
                new List<(string fruit, decimal price, decimal total)>();

            foreach (var item in shoppingList)
            {
                string name = item.Item1;
                int quantity = item.Item2;

                decimal price = Prices[name];
                decimal total = price * quantity;

                if (Discounts.ContainsKey(name))
                {
                    int discount = Discounts[name];
                    total = total - (total * discount / 100);
                }

                result.Add((name, price, total));
            }

            return result.OrderBy(x => x.fruit);
        }
    }
}
