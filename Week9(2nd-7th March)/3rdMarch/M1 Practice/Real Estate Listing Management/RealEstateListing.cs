using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Listing_Management
{
    internal class RealEstateListing:IRealEstateListing
    {
        public int id {  get; set; }
        public string title {  get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string location {  get; set; }

    }
}
