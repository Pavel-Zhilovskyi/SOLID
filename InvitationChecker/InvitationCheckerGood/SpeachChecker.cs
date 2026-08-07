using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationCheckerGood;

internal class SpeachChecker : IApplicationChecker
{
    public bool Check(Application application)
    {
        if (application.hasSpeach) return true;
        return false;
    }
}