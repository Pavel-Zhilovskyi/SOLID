using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationCheckerGood;

internal class PaymentChecker : IApplicationChecker
{
    public bool Check(Application application)
    {
        if (application.isPaid) return true;
        return false;
    }
}