using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Listing_Management
{
    internal class RealEstateApp:IRealEstateApp
    {
        private List<IRealEstateListing> listings=new List<IRealEstateListing>();
        public void AddListing(IRealEstateListing listing)
        {
            listings.Add(listing);
        }
        public  void RemoveListing(int listingID)
        {
            var l=listings.FirstOrDefault(f=>f.id==listingID);
            if (l != null)
            {
                listings.Remove(l);
            }
        }
        public void UpdateListing(IRealEstateListing listing)
        {
            var existing = listings.FirstOrDefault(l => l.id == listing.id);

            if (existing != null)
            {
                existing.title = listing.title;
                existing.description = listing.description;
                existing.price = listing.price;
                existing.location = listing.location;
            }
        }

        public List<IRealEstateListing> GetListings()
        {
            return listings;
        }

        public List<IRealEstateListing> GetListingsByLocation(string location)
        {
            return listings
                .Where(l => l.location.Equals(location, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<IRealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice)
        {
            return listings
                .Where(l => l.price >= minPrice && l.price <= maxPrice)
                .ToList();
        }
    }
}
