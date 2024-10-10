using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class CarWarehouse : IDeliveryService
    {
        private readonly List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
            Console.WriteLine($"New {car.Model} has been added  to the warehouse.\n");
        }

        public void ShowAllCars()
        {
            int totalCars = 0;
            Dictionary<string, int> carCountByModel = new Dictionary<string, int>();

            foreach (var car in cars)
            {
                totalCars++;

                if (carCountByModel.ContainsKey(car.Model))
                {
                    carCountByModel[car.Model]++;
                }
                else
                {
                    carCountByModel[car.Model] = 1;
                }
            }

            Console.WriteLine($"Total number of cars is: {totalCars}");

            foreach (var keyValuePair in carCountByModel)
            {
                Console.WriteLine($"Number of {keyValuePair.Key} cars: {keyValuePair.Value}");
            }
        }

        public bool IsCarInWarehouse(Car car)
        {
            return cars.Contains(car);
        }

        public void DeliverCar(Car car)
        {
            if (IsCarInWarehouse(car))
            {
                cars.Remove(car);
                Console.WriteLine($"\nThe {car.Model} has been delivered and removed from the warehouse.\n");
            }
            else
            {
                Console.WriteLine($"The {car.Model} is not in the warehouse and cannot be delivered.\n");
            }
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
