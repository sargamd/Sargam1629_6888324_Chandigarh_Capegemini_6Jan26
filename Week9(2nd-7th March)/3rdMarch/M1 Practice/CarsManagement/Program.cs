namespace CarsManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                cars.Add(new Car(input[0], input[1], int.Parse(input[2])));
            }

            CarManager manager = new CarManager(cars);

            var expensive = manager.MostExpensiveCar();
            Console.WriteLine($"The most expensive car is {expensive.Brand} {expensive.Model}");

            var cheapest = manager.CheapestCar();
            Console.WriteLine($"The cheapest car is {cheapest.Brand} {cheapest.Model}");

            Console.WriteLine($"Average price: {manager.AveragePriceOfCars()}");

            var dict = manager.MostExpensiveModelForEachBrand();

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Model} {item.Value.Price}");
            }
        }
    }
}
