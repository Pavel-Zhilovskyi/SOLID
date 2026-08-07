using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationChecker;

internal class PaymentChecker
{
    public bool Check(Application application)
    {
        if (application.isPaid) return true;
        return false;
    }
}