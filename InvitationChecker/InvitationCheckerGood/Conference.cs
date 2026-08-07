namespace InvitationCheckerGood;

internal class Conference
{
    private readonly List<IApplicationChecker> checkers;

    public Conference(List<IApplicationChecker> checkers)
    {
        this.checkers = checkers;
    }

    public bool Register(Application application)
    {
        foreach (var checker in checkers)
        {
            if (!checker.Check(application))
                return false;
        }

        return true;
    }
}