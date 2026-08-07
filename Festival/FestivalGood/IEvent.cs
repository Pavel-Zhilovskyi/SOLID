namespace FestivalGood;

public interface IEvent
{
    string Name { get; }

    void Prepare();
    void Start();
    void Finish();
}