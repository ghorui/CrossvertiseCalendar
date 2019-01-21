using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossvertiseCalendar.Models
{
    public class CalendarEntry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Organiser { get; set; }
        public List<string> Attendees { get; set; }
    }

    public class RootObject
    {
        public List<CalendarEntry> calendarEntry { get; set; }
    }
}