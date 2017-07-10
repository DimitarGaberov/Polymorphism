using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            base.FuelQuantity = fuelQuantity;
            base.FuelConsumption = fuelConsumption;
            base.TankCapacity = tankCapacity;
        }

        public override bool CanTravel(double distance)
        {
            if (distance * (FuelConsumption + 1.6) <= FuelQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }

        public override void PrintTravelled(double distance)
        {
            Console.WriteLine($"Truck travelled {distance} km");
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:F2}";
        }
    }
}
