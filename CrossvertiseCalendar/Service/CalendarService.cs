using CrossvertiseCalendar.Data;
using CrossvertiseCalendar.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrossvertiseCalendar.Service
{
    public class CalendarService
    {
        public List<CalendarEntry> GetCalendarEntriesByMonth(int month)
        {
            var dataDump = new DataDump();
            List<CalendarEntry> calendarEntries = dataDump.GetDataDump();
            var calendarEntriesToDisplay = calendarEntries.Where(c => c.Date.Month == month).Select(d => d).ToList();

            return calendarEntriesToDisplay;
        }

        public List<CalendarEntry> GetCalendarEntriesForMonthById(string id)
        {
            var dataDump = new DataDump();
            List<CalendarEntry> calendarEntries = dataDump.GetDataDump();
            var month = calendarEntries.Where(c => c.Id.ToString() == id).Select(d => d.Date.Month).FirstOrDefault();
            var calendarEntriesToDisplay = calendarEntries.Where(c => c.Date.Month == month).Select(d => d).ToList();

            return calendarEntriesToDisplay;
        }
    }
}