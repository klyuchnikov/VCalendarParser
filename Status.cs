using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCalendarParser
{
    public enum Status
    {
        ACCEPTED,
        NEEDSACTION = 0,
        SENT,
        TENTATIVE,
        CONFIRMED,
        DECLINED,
        COMPLETED,
        DELEGATED

    }
}
