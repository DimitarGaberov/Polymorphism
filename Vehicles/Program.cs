using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(' ').ToArray();
            var truckInfo = Console.ReadLine().Split(' ').ToArray();
            var busInfo = Console.ReadLine().Split(' ').ToArray();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            var numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandTokens = Console.ReadLine().Split(' ').ToArray();
                if (commandTokens[0] == "Drive")
                {
                    if (commandTokens[1] == "Car")
                    {
                        if (car.CanTravel(double.Parse(commandTokens[2])))
                        {
                            car.PrintTravelled(double.Parse(commandTokens[2]));
                            car.FuelQuantity -= double.Parse(commandTokens[2]) * (car.FuelConsumption + 0.9);
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (commandTokens[1] == "Bus")
                    {
                        if (bus.CanTravelFull(double.Parse(commandTokens[2])))
                        {
                            bus.PrintTravelled(double.Parse(commandTokens[2]));
                            bus.FuelQuantity -= double.Parse(commandTokens[2]) * (bus.FuelConsumption + 1.4);
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }
                    else
                    {
                        if (truck.CanTravel(double.Parse(commandTokens[2])))
                        {
                            truck.PrintTravelled(double.Parse(commandTokens[2]));
                            truck.FuelQuantity -= double.Parse(commandTokens[2]) * (truck.FuelConsumption + 1.6);
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                }
                else if (commandTokens[0] == "DriveEmpty")
                {
                    if (commandTokens[1] == "Bus")
                    {
                        if (bus.CanTravel(double.Parse(commandTokens[2])))
                        {
                            bus.PrintTravelled(double.Parse(commandTokens[2]));
                            bus.FuelQuantity -= double.Parse(commandTokens[2]) * bus.FuelConsumption;
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }
                }
                else
                {
                    if (double.Parse(commandTokens[2]) <= 0)
                    {
                        Console.WriteLine("Fuel must be a positive number");
                    }
                    else
                    {
                        if (commandTokens[1] == "Car")
                        {
                            if (!car.CanRefuel(double.Parse(commandTokens[2])))
                            {
                                Console.WriteLine("Cannot fit fuel in tank");
                            }
                            else
                            {
                                car.Refuel(double.Parse(commandTokens[2]));
                            }
                        }
                        else if (commandTokens[1] == "Bus")
                        {
                            if (!bus.CanRefuel(double.Parse(commandTokens[2])))
                            {
                                Console.WriteLine("Cannot fit fuel in tank");
                            }
                            else
                            {
                                bus.Refuel(double.Parse(commandTokens[2]));
                            }
                        }
                        else
                        {
                            truck.Refuel(double.Parse(commandTokens[2]));
                        }
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
