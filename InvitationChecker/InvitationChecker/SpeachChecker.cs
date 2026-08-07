using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationChecker;

internal class SpeachChecker
{
    public bool Check(Application application)
    {
        if (application.hasSpeach) return true;
        return false;
    }
}