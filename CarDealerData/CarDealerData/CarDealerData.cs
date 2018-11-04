using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    class CarDealerData
    {
        static void Main(string[] args)
        {
            try
            { 
                DataRequest request = new DataRequest();
                CarData cars = new CarData();
                string brand;
                string model;
                string command;
                int quantity;
                int prise;
                for (int i = 0; i < 5 ;i++)
                {
                    Console.Write("Brand: ");
                    brand = Console.ReadLine();
                    Console.Write("Model: ");
                    model = Console.ReadLine();
                    Console.Write("Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Price: ");
                    prise = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    cars.AddCar(brand, model, quantity, prise);
                }
                request.SetCommand(new CarDataCommands(cars));
                CommandChecker checker = new CommandChecker(request);
                while (true)
                {
                    Console.Write("Enter Command: ");
                    command = Console.ReadLine();
                    if (command == "exit") break;
                    checker.Check(command);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred");
            }
        }
    }
}
