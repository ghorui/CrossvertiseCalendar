using CrossvertiseCalendar.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossvertiseCalendar.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                RedirectToAction("Index", "Calendar");
            }
            ViewBag.appointmentId = id;
            CalendarService calendarService = new CalendarService();
            var result = calendarService.GetCalendarEntriesForMonthById(id);
            int month = result.Select(r => r.Date.Month).FirstOrDefault();
            HighlightMonth(month);
            return View(result);
        }

        [NonAction]
        private void HighlightMonth(int month)
        {
            switch (month)
            {
                case 1:
                    ViewBag.selectJan = "active";
                    break;
                case 2:
                    ViewBag.selectFeb = "active";
                    break;
                case 3:
                    ViewBag.selectMar = "active";
                    break;
                case 4:
                    ViewBag.selectApr = "active";
                    break;
                case 5:
                    ViewBag.selectMay = "active";
                    break;
                case 6:
                    ViewBag.selectJun = "active";
                    break;
                case 7:
                    ViewBag.selectJul = "active";
                    break;
                case 8:
                    ViewBag.selectAug = "active";
                    break;
                case 9:
                    ViewBag.selectSep = "active";
                    break;
                case 10:
                    ViewBag.selectOct = "active";
                    break;
                case 11:
                    ViewBag.selectNov = "active";
                    break;
                case 12:
                    ViewBag.selectDec = "active";
                    break;
            }
        }
    }
}