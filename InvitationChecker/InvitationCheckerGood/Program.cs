namespace InvitationCheckerGood;

internal class Program
{
    static void Main(string[] args)
    {
        var checkList = new List<IApplicationChecker>()
        {
            new AgeChecker(), new SpeachChecker(), new PaymentChecker()
        };

        var conference = new Conference(checkList);

        var application = new Application("John Doe", 33, true, true);

        bool succeeded = conference.Register(application);

        if (succeeded)
        {
            Console.WriteLine($"{application.name} was successfuly added to conference participants");
        }
        else
        {
            Console.WriteLine($"Sadly {application.name} wasn`t able to join the conference =(");
        }
    }
}