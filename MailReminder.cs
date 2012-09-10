﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCalendarParser
{
    public struct MailReminder
    {
        public DateTime RunTime;
        public string SnoozeTime;
        public int RepeatCount;
        public string EmailAddress;
        public string Note;
    }
}
