using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_Management
{
    internal class Product:IProduct
    {
        public string Name { get; set; }
        public string Category {  get; set; }
        public int Stock {  get; set; }
        public int Price {  get; set; }

    }
}
