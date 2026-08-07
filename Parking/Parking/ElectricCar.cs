namespace ParkingBad;

internal class ElectricCar : Vehicle
{
    public ElectricCar(string plate) : base(plate)
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
        //throw new NotSupportedException("Электромобиль нельзя заправить бензином.");
    }
}