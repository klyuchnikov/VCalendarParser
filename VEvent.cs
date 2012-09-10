using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCalendarParser
{
    public class VEvent
    {

        // ATTENDEE
        // AALARM
        // CATEGORIES
        private List<string> _categories;
        public string[] CATEGORIES { get { return _categories.ToArray(); } }

        // CLASS
        public ClassAccess CLASS { get; private set; }

        // DCREATED
        public DateTime DCREATED { get; private set; }

        // COMPLETED
        public DateTime COMPLETED { get; private set; }

        // DESCRIPTION
        public string DESCRIPTION { get; private set; }

        // DALARM
        public DisplayReminder DALARM { get; private set; }

        // DUE
        public DateTime DUE { get; private set; }

        // DTEND
        public DateTime DTEND { get; private set; }


        // EXDATE   !!
        private List<DateTime> _exdate;
        public DateTime[] EXDATE { get { return _exdate.ToArray(); } }

        // EXRULE   !!
        public string EXRULE { get; private set; }

        // LAST-MODIFIED
        public DateTime LASTMODIFIED { get; private set; }

        // LOCATION !!
        public string LOCATION { get; private set; }

        // MALARM
        public MailReminder MALARM { get; private set; }
        // RNUM
        public int RNUM { get; private set; }

        // PRIORITY
        public int PRIORITY { get; private set; }

        // PALARM
        public ProcedureReminder PALARM { get; private set; }

        // RELATED-TO - not implementations 

        // RDATE   !!
        private List<DateTime> _rdate;
        public DateTime[] RDATE { get { return _rdate.ToArray(); } }

        // RRULE
        public string RRULE { get; private set; }

        // RESOURCES
        public string RESOURCES { get; private set; }

        // SEQUENCE
        public int SEQUENCE { get; private set; }

        // DTSTART
        public DateTime DTSTART { get; private set; }

        // STATUS
        public Status STATUS { get; private set; }

        // SUMMARY
        public string SUMMARY { get; private set; }

        // TRANSP - not implementations 

        // URL
        public Uri URL { get; private set; }

        // UID
        public string UID { get; private set; }


    }
}
