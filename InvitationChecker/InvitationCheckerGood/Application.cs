namespace InvitationCheckerGood;

internal class Application
{
    public readonly string name;
    public readonly bool isPaid;
    public readonly int age;
    public readonly bool hasSpeach;

    public Application(string name, int age, bool isPaid, bool hasSpeach)
    {
        this.name = name;
        this.isPaid = isPaid;
        this.age = age;
        this.hasSpeach = hasSpeach;
    }
}