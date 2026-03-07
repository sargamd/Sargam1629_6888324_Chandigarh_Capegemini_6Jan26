namespace Real_Estate_Listing_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRealEstateApp app = new RealEstateApp();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(',');

                RealEstateListing listing = new RealEstateListing
                {
                    id = Convert.ToInt32(data[0]),
                    title = data[1],
                    description = data[2],
                    price = Convert.ToInt32(data[3]),
                    location = data[4]
                };

                app.AddListing(listing);
            }

            Console.WriteLine("All Listings:");
            foreach (var l in app.GetListings())
            {
                Console.WriteLine($"{l.id} {l.title} {l.price} {l.location}");
            }

            string locationSearch = Console.ReadLine();
            Console.WriteLine("Listings By Location:");

            foreach (var l in app.GetListingsByLocation(locationSearch))
            {
                Console.WriteLine($"{l.id} {l.title} {l.price} {l.location}");
            }

            string[] range = Console.ReadLine().Split(' ');
            int minPrice = Convert.ToInt32(range[0]);
            int maxPrice = Convert.ToInt32(range[1]);

            Console.WriteLine("Listings By Price Range:");

            foreach (var l in app.GetListingsByPriceRange(minPrice, maxPrice))
            {
                Console.WriteLine($"{l.id} {l.title} {l.price} {l.location}");
            }
        }
    }
    
}
