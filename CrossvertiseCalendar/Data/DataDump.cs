using CrossvertiseCalendar.Models;
using System;
using System.Collections.Generic;

namespace CrossvertiseCalendar.Data
{

    public class DataDump
    {
        public List<CalendarEntry> GetDataDump()
        {
            List<CalendarEntry> calendarEntries = new List<CalendarEntry>();

            #region datadump creation

            DateTime d1;
            DateTime.TryParse("02/19/2019 5:00pm", out d1);
            DateTime d2;
            DateTime.TryParse("02/08/2019 5:00pm", out d2);
            DateTime d3;
            DateTime.TryParse("03/09/2019 5:00pm", out d3);
            DateTime d4;
            DateTime.TryParse("04/12/2019 3:00pm", out d4);
            DateTime d5;
            DateTime.TryParse("05/12/2019 3:00pm", out d5);
            DateTime d6;
            DateTime.TryParse("08/12/2019 3:00pm", out d6);
            DateTime d7;
            DateTime.TryParse("11/12/2019 3:00pm", out d7);
            DateTime d8;
            DateTime.TryParse("02/15/2019 2:15pm", out d8);

            calendarEntries.Add(new CalendarEntry { Id = 1, Date = d1, Description = "Project Meeting", Organiser = "Max Mustermann", Attendees = new List<string> { "John Smith", "Robert Turner", "Erika Gabler" } });
            calendarEntries.Add(new CalendarEntry { Id = 2, Date = d2, Description = "Team Meeting", Organiser = "Tarun K Ghorui", Attendees = new List<string> { "John Smith", "Max Mustermann", "Robert Turner", "Erika Gabler" } });
            calendarEntries.Add(new CalendarEntry { Id = 3, Date = d3, Description = "Lunch with Joe", Organiser = "Joe Bastianich", Attendees = new List<string> { "Tarun K Ghorui", "John Smith", "Christine Ha", "Gerron Hurt" } });
            calendarEntries.Add(new CalendarEntry { Id = 4, Date = d4, Description = "Sprint backlog discussion", Organiser = "John Smith", Attendees = new List<string> { "Tarun K Ghorui", "Max Mustermann", "Robert Turner", "Erika Gabler" } });
            calendarEntries.Add(new CalendarEntry { Id = 5, Date = d5, Description = "Project Meeting", Organiser = "Max Mustermann", Attendees = new List<string> { "John Smith", "Robert Turner", "Erika Gabler" } });
            calendarEntries.Add(new CalendarEntry { Id = 6, Date = d6, Description = "Project Meeting", Organiser = "Max Mustermann", Attendees = new List<string> { "John Smith", "Robert Turner", "Erika Gabler" } });
            calendarEntries.Add(new CalendarEntry { Id = 7, Date = d7, Description = "Project Meeting", Organiser = "Max Mustermann", Attendees = new List<string> { "John Smith", "Robert Turner", "Erika Gabler" } });
            calendarEntries.Add(new CalendarEntry { Id = 8, Date = d8, Description = "Birthday bash", Organiser = "Max Mustermann", Attendees = new List<string> { "John Smith", "Robert Turner", "Erika Gabler", "Tarun K Ghorui", "Christine Ha", "Gerron Hurt" } });

            #endregion datadump creation

            return calendarEntries;
        }
    }

}