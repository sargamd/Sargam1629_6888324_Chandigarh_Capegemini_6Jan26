using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Management
{
    internal interface IProduct
    {
        string Name { get; set; }
        string Category {  get; set; }
        int Stock {  get; set; }
        int Price {  get; set; }

    }
}
