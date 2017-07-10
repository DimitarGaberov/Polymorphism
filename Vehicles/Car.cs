using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            base.FuelQuantity = fuelQuantity;
            base.FuelConsumption = fuelConsumption;
            base.TankCapacity = tankCapacity;
        }

        public override bool CanTravel(double distance)
        {
            if (distance * (FuelConsumption + 0.9) <= FuelQuantity)
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
            this.FuelQuantity += liters;
        }

        public override void PrintTravelled(double distance)
        {
            Console.WriteLine($"Car travelled {distance} km");
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:F2}";
        }
    }
}
