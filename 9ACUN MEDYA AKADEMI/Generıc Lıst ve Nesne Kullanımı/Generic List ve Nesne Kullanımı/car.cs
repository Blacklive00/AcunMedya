using System;

namespace CarFuelConsumptionApp
{
   
    public class Car
    {
        
        public string Marka { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; }
        public double TotalDistance { get; set; }

        public double TotalFuelConsumption()
        {
            

            return (TotalDistance / 100) * FuelConsumption;
        }
    }
}
