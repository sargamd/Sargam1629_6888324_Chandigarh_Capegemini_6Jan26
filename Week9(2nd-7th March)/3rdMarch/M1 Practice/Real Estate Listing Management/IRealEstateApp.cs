using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Listing_Management
{
    internal interface IRealEstateApp
    {
        void AddListing(IRealEstateListing listing);
        void RemoveListing(int listingID);
        void UpdateListing(IRealEstateListing listing);
        List<IRealEstateListing> GetListings();
        List<IRealEstateListing> GetListingsByLocation(string location);
        List<IRealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice);
    }
}
