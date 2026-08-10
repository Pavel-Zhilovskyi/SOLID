using System;
using System.Collections.Generic;
using System.Text;

namespace LSPBad;

internal abstract class BackupSource
{
    public abstract void GetFiles();
    public abstract int GetSize();
    public abstract void DeleteSource();
}