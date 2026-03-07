using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement
{
    internal class CarManager
    {
        private List<Car> cars;

        public CarManager(List<Car> cars)
        {
            this.cars = cars;
        }

        public Car MostExpensiveCar()
        {
            return cars.OrderByDescending(c => c.Price).First();
        }

        public Car CheapestCar()
        {
            return cars.OrderBy(c => c.Price).First();
        }

        public int AveragePriceOfCars()
        {
            return (int)Math.Round(cars.Average(c => c.Price));
        }

        public Dictionary<string, Car> MostExpensiveModelForEachBrand()
        {
            return cars
                .GroupBy(c => c.Brand)
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderByDescending(c => c.Price).First()
                );
        }
    }
}
