using System;

namespace Exercise_2
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public string EngineNumber { get; }

        public Vehicle(string model, string color, string status)
        {
            Model = model;
            Color = color;
            Status = status;
            EngineNumber = GenerateEngineNumber();
        }

        private string GenerateEngineNumber()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }

        public virtual void DisplayVehicleInformation()
        {
            Console.WriteLine($"{Model} - {Color} - {Status} - {EngineNumber}");
        }

        public abstract void StartProduction();
    }
}
