using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class HelperClass
    {
        public void RunProgram()
        {
            CarFactory factory = new CarFactory("Fourth Car Factory");

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create a new car");
                Console.WriteLine("2. Deliver a car");
                Console.WriteLine("3. Show all cars");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        factory.CreateCar();
                        break;
                    case "2":
                        factory.DeliverCar();
                        break;
                    case "3":
                        factory.ShowAllCars();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
