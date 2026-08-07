using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingBad
{
    internal class Car : Vehicle
    {
        public Car(string plate) : base(plate) 
        {
        }

        public override void EnterParking(Parking parking)
        {
            parking.AddVehicle(this);
        }

        public override void LeaveParking(Parking parking)
        {
            parking.RemoveVehicle(this);
        }

        public override void Refuel()
        {
            Console.WriteLine("Заправлена бензином.");
        }
    }
}