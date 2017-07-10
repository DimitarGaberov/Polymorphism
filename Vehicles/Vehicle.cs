using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }
        
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
            
        }

        public abstract bool CanTravel(double distance);
        public abstract void PrintTravelled(double distance);
        public abstract void Refuel(double liters);

        public virtual bool CanRefuel(double liters)
        {
            if (this.fuelQuantity + liters > this.tankCapacity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual bool CanTravelFull(double distance)
        {
            if (distance * (FuelConsumption + 1.4) <= FuelQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
