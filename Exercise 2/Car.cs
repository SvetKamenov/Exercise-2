using System;

namespace Exercise_2
{
    public class Car : Vehicle
    {
        public readonly string FuelType;

        public Car(string model, string color, string status, string fuelType)
        : base(model, color, status)
        {
            FuelType = fuelType;
        }

        public override void StartProduction()
        {
            Console.WriteLine("Car production is in progress...\n");
        }

        public override void DisplayVehicleInformation()
        {
            Console.WriteLine($"Car model: {Model}, with color: {Color}, engine number: {EngineNumber}, fuel type: {FuelType} and the status is: {Status}");
        }

        public void RefillCar()
        {
            if (FuelType.Equals("Electric", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The car is being charged...");
            }
            else if (FuelType.Equals("Gasoline", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The car is being refueled with gasoline...");
            }
            else if (FuelType.Equals("Diesel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The car is being refueled with diesel...");
            }
            else
            {
                Console.WriteLine("Unknown fuel type. The car is not refilled.");
            }
        }
    }
}
