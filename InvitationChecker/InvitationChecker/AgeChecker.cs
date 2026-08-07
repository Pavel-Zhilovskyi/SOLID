using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationChecker;

internal class AgeChecker
{
    public bool Check(Application application)
    {
        if (application.age >= 16) return true;
        return false;
    }
}
