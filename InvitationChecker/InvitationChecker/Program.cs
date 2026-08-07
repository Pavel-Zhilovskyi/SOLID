namespace InvitationChecker;

internal class Program
{
    static void Main(string[] args)
    {
        var paymentChecker = new PaymentChecker();
        var ageChecker = new AgeChecker();
        var speachChecker = new SpeachChecker();

        var application = new Application("John Doe", 33, true, true);

        var conference = new Conference(paymentChecker, ageChecker, speachChecker);

        bool succeeded = conference.Register(application);

        if(succeeded)
        {
            Console.WriteLine($"{application.name} was successfuly added to conference participants");
        }
        else
        {
            Console.WriteLine($"Sadly {application.name} wasn`t able to join the conference =(");
        }
    }
}