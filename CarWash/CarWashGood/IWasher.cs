namespace CarWashGood;

internal interface IWasher
{
    void Start();

    void ApplyFoam(Car car);

    void Wash(Car car);

    void WashOff(Car car);

    void Dry(Car car);

    void Stop();
}