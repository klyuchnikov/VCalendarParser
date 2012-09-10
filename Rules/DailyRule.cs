using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCalendarParser.Rules
{
    public struct DailyRule
    {
        public int Occurrence;
        public DateTime? EndDate;
        public int Interval;
    }
    public struct WeeklyRule
    {
        public int Occurrence;
        public DateTime? EndDate;
        public int Interval;
        public DayOfWeek Weekdays;


        public WeeklyRule(int y)
        {
            Weekdays = DayOfWeek.Monday | DayOfWeek.Saturday;
            Occurrence = 0;
            EndDate = null;
            Interval = 0;
        }
    }
    
    public struct MonthlyRule
    {
        public int Occurrence;
        public DateTime? EndDate;
        public int Interval;
    }
}
