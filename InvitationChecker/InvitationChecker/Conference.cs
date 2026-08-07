using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationChecker;

internal class Conference
{
    private readonly PaymentChecker _paymenChecker;
    private readonly AgeChecker _ageChecker;
    private readonly SpeachChecker _speackerChecker;

    public Conference(PaymentChecker paymentChecker, AgeChecker ageChecker, SpeachChecker speackerChecker)
    {
        _paymenChecker = paymentChecker;
        _ageChecker = ageChecker;
        _speackerChecker = speackerChecker;
    }

    public bool Register(Application application)
    {
        if (!_paymenChecker.Check(application) || 
            !_ageChecker.Check(application) ||
            !_speackerChecker.Check(application))
        {
            return false;
        }
        return true;
    }
}