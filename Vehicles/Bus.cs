using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            base.FuelQuantity = fuelQuantity;
            base.FuelConsumption = fuelConsumption;
            base.TankCapacity = tankCapacity;
        }

        public override bool CanTravel(double distance)
        {
            if (distance * FuelConsumption <= FuelQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void PrintTravelled(double distance)
        {
            Console.WriteLine($"Bus travelled {distance} km");
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:F2}";
        }
    }
}
