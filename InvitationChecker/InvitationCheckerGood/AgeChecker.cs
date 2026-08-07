using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationCheckerGood;

internal class AgeChecker : IApplicationChecker
{
    public bool Check(Application application)
    {
        if (application.age >= 16) return true;
        return false;
    }
}
