using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Listing_Management
{
    internal interface IRealEstateListing
    {
        int id { get; set; }
        string title { get; set; }
        string description { get; set; }
        int price { get; set; }
        string location { get; set; }
    }
}
