using System;
using System.Runtime.ConstrainedExecution;

namespace Exercise_2
{
    public class CarFactory : CarWarehouse, IProductionProcess
    {
        public string FactoryName { get; }

        public CarFactory(string factoryName)
        {
            FactoryName = factoryName;
            Console.WriteLine($"Welcome to the {factoryName}!\n");
        }

        public void Assemble()
        {
            Console.WriteLine("The car was assembled successfully.");
        }

        public void Paint()
        {
            Console.WriteLine("The car was painted successfully.");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Installing the engine...");
        }

        public void TestDrive()
        {
            Console.WriteLine("The car is ready for a test drive.");
        } 

        public void QualityCheck()
        {
            Console.WriteLine("The quality check is in progress...");
        }

        private void LogProduction(Car car)
        {
            Console.WriteLine($"Log data for: {car.Model}, Engine number: {car.EngineNumber}");
        }

        public void ProduceVehicle(Car car)
        {
            car.StartProduction();
            Assemble();
            Paint();
            InstallEngine();
            QualityCheck();
            car.RefillCar();
            TestDrive();
            car.DisplayVehicleInformation();
            LogProduction(car);
            AddCar(car);
        }

        public void CreateCar()
        {
            Console.Write("Enter car model: ");
            string model = Console.ReadLine();
            Console.Write("Enter car color: ");
            string color = Console.ReadLine();
            Console.Write("Enter car status: ");
            string status = Console.ReadLine();
            Console.Write("Enter car fuel type /Electric, Diesel or Gasoline/: ");
            string fuelType = Console.ReadLine();

            Car carToProduce = new Car(model, color, status, fuelType);
            ProduceVehicle(carToProduce);
        }

        public void DeliverCar()
        {
            Console.Write("Enter car's unique engine number to deliver: ");
            string engineNumber = Console.ReadLine();

            Car carToDeliver = null;
            foreach (var car in GetCars())
            {
                if (car.EngineNumber.Equals(engineNumber, StringComparison.OrdinalIgnoreCase))
                {
                    carToDeliver = car;
                    break;
                }
            }

            if (carToDeliver != null)
            {
                DeliverCar(carToDeliver);
            }
            else
            {
                Console.WriteLine($"Car with engine number: {engineNumber} not found in the warehouse.");
            }
        }
    }
}
